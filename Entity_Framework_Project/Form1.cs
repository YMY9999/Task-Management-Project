using Entity_Framework_Project.Context;
using Entity_Framework_Project.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Timers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity_Framework_Project
{
    public partial class Form1 : Form
    {
        private readonly int loggedInUserId; 
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalPages = 1;
        AppDbContext AppContext = new AppDbContext();

        private string currentMode = "Default"; 
        private Task_Status? filterStatus = null;
        private string searchText = null;
        private System.Timers.Timer overdueTimer; 

        public Form1(int userId)
        {
            loggedInUserId = userId; 
            InitializeComponent();
            LoadComboBoxValuesToDataGrid();
            RefreshDataGrid();
            dataGridView1.RowPrePaint += DataGridView1_RowPrePaint;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            DeleteBtn.Enabled = false;
            EditBtn.Enabled = false;
            overdueTimer = new System.Timers.Timer(700000); // 5 minute interval
            overdueTimer.Elapsed += OverdueTimer_Elapsed;
            overdueTimer.AutoReset = true;
            overdueTimer.Start();
        }

        #region track_overDue_tasks

        private void OverdueTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckAndAlertOverdueTasks();
        }
        private void CheckOverdueBtn_Click(object sender, EventArgs e)
        {
            CheckAndAlertOverdueTasks();
        }

        private void CheckAndAlertOverdueTasks()
        {
            using (var context = new AppDbContext()) // Ensure fresh data
            {
                var overdueCount = context.TaskItems
                                    .Where(t => t.UserId == loggedInUserId &&
                                                t.DueDate < DateTime.Now &&
                                                t.status != Task_Status.Completed)
                                    .Count();  

                if (overdueCount > 0)
                {
                    string message = $"Alert: You have {overdueCount} overdue task(s) marked in red!\nPlease check and update their status.";

                    if (InvokeRequired)
                        Invoke(new Action(() => MessageBox.Show(message, "Overdue Task Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    else
                        MessageBox.Show(message, "Overdue Task Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        #endregion

        #region Task_Average_Completion_Time
        private void AvgCompletionTimeBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var completedTasks = context.TaskItems
                                    .Where(t => t.UserId == loggedInUserId) 
                                    .Where(t => t.status == Task_Status.Completed)
                                    .ToList();

                if (!completedTasks.Any())
                {
                    MessageBox.Show("No completed tasks found to calculate average completion time.");
                    return;
                }

                // Assuming tasks are completed around their DueDate (not ideal but workable)
                var completionTimes = completedTasks
                    .Select(t => (t.DueDate - DateTime.Now).TotalDays) // Use current time as completion proxy
                    .Where(t => t >= 0) // Filter out future DueDates
                    .ToList();

                if (!completionTimes.Any())
                {
                    MessageBox.Show("No valid completion times available (all DueDates are in the future).");
                    return;
                }

                double averageDays = completionTimes.Average();
                TimeSpan averageTimeSpan = TimeSpan.FromDays(averageDays);

                string result = $"Estimated average completion time (based on DueDate): {averageTimeSpan.Days} days, {averageTimeSpan.Hours} hours, {averageTimeSpan.Minutes} minutes";
                MessageBox.Show(result, "Average Task Completion Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Add_Btn
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StatuscomboBox.SelectedItem == null)
            {
                MessageBox.Show("You must select a status.");
                return;
            }
            if (PrioritycomboBox.SelectedItem == null)
            {
                MessageBox.Show("You must select a priority.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TitleTxt.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }
            using (var context = new AppDbContext())
            {
                TaskItem newtaskItem = new TaskItem
                {
                    UserId = loggedInUserId,
                    Title = TitleTxt.Text,
                    Description = DescriptionTxt.Text,
                    DueDate = dateTimePicker1.Value,
                    status = (Task_Status)StatuscomboBox.SelectedItem,
                    priority = (Task_Priority)PrioritycomboBox.SelectedItem,
                    CategoryId = (int)CategorycomboBox.SelectedValue
                };

                AppContext.TaskItems.Add(newtaskItem);
                AppContext.SaveChanges();
                RefreshDataGrid();
                MessageBox.Show("Task added successfully!");
            }
        }
        #endregion

        # region Delete_Btn
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int taskIndex = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            using (var context = new AppDbContext()) // Use a new context
            {
                var taskToDelete = AppContext.TaskItems
                    .Where(t => t.UserId == loggedInUserId)  // Ensure it's user's task
                    .FirstOrDefault(t => t.Id == taskIndex);

                AppContext.TaskItems.Remove(taskToDelete);
                AppContext.SaveChanges();
                LoadDataGridBasedOnMode(); // Use current mode instead of RefreshDataGrid
            }
        }
        #endregion

        #region Edit
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            int selectedTaskId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

            using (var context = new AppDbContext()) // Use a new context
            {
                var taskToEdit = AppContext.TaskItems
                    .Where(t => t.UserId == loggedInUserId)  // Ensure it's user's task
                    .FirstOrDefault(t => t.Id == selectedTaskId);

                if (taskToEdit != null)
                {
                    taskToEdit.Title = TitleTxt.Text;
                    taskToEdit.Description = DescriptionTxt.Text;
                    taskToEdit.DueDate = dateTimePicker1.Value;
                    taskToEdit.status = (Task_Status)StatuscomboBox.SelectedItem;
                    taskToEdit.priority = (Task_Priority)PrioritycomboBox.SelectedItem;
                    taskToEdit.CategoryId = (int)CategorycomboBox.SelectedValue;

                    AppContext.SaveChanges();
                    LoadDataGridBasedOnMode(); // Use current mode instead of RefreshDataGrid
                    MessageBox.Show("Task updated successfully!");
                }
                else
                {
                    MessageBox.Show("Task not found!");
                }
            }
        }
        private void FillSpaceWithValuesToEdit(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return; // No row selected, so do nothing
            }

            int selectedTaskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            var selectedRow = AppContext.TaskItems
                 .Where(t => t.UserId == loggedInUserId)  
                 .FirstOrDefault(t => t.Id == selectedTaskId);

            if (selectedRow != null)
            {
                // Populate all input fields with the selected task's values
                TitleTxt.Text = selectedRow.Title;
                DescriptionTxt.Text = selectedRow.Description;
                dateTimePicker1.Value = selectedRow.DueDate;
                StatuscomboBox.SelectedItem = selectedRow.status;
                PrioritycomboBox.SelectedItem = selectedRow.priority;
                CategorycomboBox.SelectedValue = selectedRow.CategoryId;
            }
            else
            {
                MessageBox.Show("Task not found!");
            }
        }

        #endregion

        #region Search_Btn
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var inputText = SearchTxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter some text.");
                return;
            }

            currentMode = "Search";
            searchText = inputText;
            currentPage = 1; // Reset to first page
            LoadDataGridBasedOnMode();
        }

        #endregion

        #region Clear_Btn
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TitleTxt.Clear();
            DescriptionTxt.Clear();
            SearchTxt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            StatuscomboBox.SelectedIndex = -1;
            PrioritycomboBox.SelectedIndex = -1;
            CategorycomboBox.SelectedIndex = -1;
            currentMode = "Default"; // Reset to default mode
            filterStatus = null;
            searchText = null;
            RefreshDataGrid();
        }
        #endregion

        # region FilterByStatus_Btn

        private void FilterByStatusBtn_Click(object sender, EventArgs e)
        {
            if (FilterByStatuscomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a status to filter.");
                return;
            }

            currentMode = "FilterByStatus";
            filterStatus = (Task_Status)FilterByStatuscomboBox.SelectedItem;
            currentPage = 1; // Reset to first page
            LoadDataGridBasedOnMode();
        }
        #endregion

        # region Sort_tasks_by_DueDate_Btn

        private void button1_Click(object sender, EventArgs e) // Sort tasks by DueDate
        {
            currentMode = "SortByDueDate";
            currentPage = 1; // Reset to first page
            LoadDataGridBasedOnMode();
        }
        #endregion

        # region Group_by_Priority_Btn
        private void GroupbyPriorityBtn_Click(object sender, EventArgs e)
        {
            currentMode = "GroupByPriority";
            currentPage = 1; // Reset to first page
            LoadDataGridBasedOnMode();
        }
        #endregion

        #region Generate_Report_Btn
        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                // Fetch all tasks
                var tasks = context.TaskItems
                     .Where(t => t.UserId == loggedInUserId)  
                     .ToList();

                // Count completed and pending tasks
                int completedCount = tasks.Count(t => t.status == Task_Status.Completed);
                int pendingCount = tasks.Count(t => t.status == Task_Status.Pending);
                int inProgressCount = tasks.Count(t => t.status == Task_Status.InProgress);
                int totalTasks = tasks.Count;

                // Calculate percentages
                double completedPercentage = totalTasks > 0 ? (completedCount * 100.0 / totalTasks) : 0;
                double pendingPercentage = totalTasks > 0 ? (pendingCount * 100.0 / totalTasks) : 0;
                double inProgressPercentage = totalTasks > 0 ? (inProgressCount * 100.0 / totalTasks) : 0;

                // Build the report string
                var report = new System.Text.StringBuilder();
                report.AppendLine("Task Status Report");
                report.AppendLine("==================");
                report.AppendLine($"Total Tasks: {totalTasks}");
                report.AppendLine($"Completed Tasks: {completedCount} ({completedPercentage:F2}%)");
                report.AppendLine($"Pending Tasks: {pendingCount} ({pendingPercentage:F2}%)");
                report.AppendLine($"In Progress Tasks: {inProgressCount} ({inProgressPercentage:F2}%)");
                report.AppendLine();
                report.AppendLine("Details:");
                report.AppendLine("- Completed Tasks:");
                foreach (var task in tasks.Where(t => t.status == Task_Status.Completed))
                {
                    report.AppendLine($"  - {task.Title} (Due: {task.DueDate:yyyy-MM-dd})");
                }
                report.AppendLine("- Pending Tasks:");
                foreach (var task in tasks.Where(t => t.status == Task_Status.Pending))
                {
                    report.AppendLine($"  - {task.Title} (Due: {task.DueDate:yyyy-MM-dd})");
                }

                // Show the report in ReportForm with counts for the chart
                ReportForm reportForm = new ReportForm(report.ToString(), completedCount, pendingCount, inProgressCount, totalTasks);
                reportForm.ShowDialog();
            }
        }
        #endregion

        #region Update_Pagination_Buttons

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataGridBasedOnMode(); // Use current mode instead of RefreshDataGrid
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataGridBasedOnMode(); // Use current mode instead of RefreshDataGrid
            }
        }

        private void UpdatePaginationButtons()
        {
            PrevBtn.Enabled = currentPage > 1;
            NextBtn.Enabled = currentPage < totalPages;
        }

        #endregion

        #region Refresh/Load_DataGrid

        public void RefreshDataGrid()
        {
            currentMode = "Default"; // Reset to default mode
            filterStatus = null;
            searchText = null;
            LoadDataGridBasedOnMode();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DeleteBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
            EditBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void LoadDataGridBasedOnMode()
        {
            var query = AppContext.TaskItems
                       .Where(t => t.UserId == loggedInUserId)
                       .AsQueryable();

            switch (currentMode)
            {
                case "FilterByStatus":
                    if (filterStatus.HasValue)
                        query = query.Where(t => t.status == filterStatus.Value);
                    break;

                case "SortByDueDate":
                    query = query.OrderBy(t => t.DueDate);
                    break;
                case "FilterByPriority":
                    var selectedPriority = (Task_Priority)FilterByPrioritycomboBox.SelectedItem;
                    query = query.Where(t => t.priority == selectedPriority);
                    break;

                case "GroupByPriority":
                    // Fetch all tasks first, then group and sort by custom priority order
                    var allTasks = AppContext.TaskItems
                        .Where(t => t.UserId == loggedInUserId)
                        .Select(t => new
                        {
                            t.Id,
                            t.Title,
                            t.Description,
                            t.DueDate,
                            t.status,
                            t.priority,
                            CategoryName = t.Category.Name
                        })
                        .ToList();

                    // Define custom order: High (3) -> Medium (2) -> Low (1)
                    var priorityOrder = new Dictionary<Task_Priority, int>
                    {
                        { Task_Priority.High, 0 },
                        { Task_Priority.Medium, 1 },
                        { Task_Priority.Low, 2 }
                    };

                    var groupedTasks = allTasks
                        .GroupBy(t => t.priority)
                        .OrderBy(g => priorityOrder[g.Key]) // Sort groups by custom order
                        .SelectMany(g => g.Select(t => new
                        {
                            Priority = g.Key.ToString(), // Display priority as string
                            t.Id,
                            t.Title,
                            t.Description,
                            t.DueDate,
                            t.status,
                            t.CategoryName
                        }))
                        .ToList();

                    totalPages = (int)Math.Ceiling((double)groupedTasks.Count / pageSize);
                    var paginatedGrouped = groupedTasks
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    dataGridView1.DataSource = paginatedGrouped;
                    UpdatePaginationButtons();
                    return; // Exit early since grouping is handled

                case "Search":
                    if (!string.IsNullOrEmpty(searchText))
                        query = query.Where(t => t.Title.ToLower().Contains(searchText) || t.Description.ToLower().Contains(searchText));
                    break;

                case "Default":
                default:
                    query = query.OrderBy(t => t.Id);
                    break;
            }

            var tasks = query
                .Select(t => new
                {
                    t.Id,
                    t.Title,
                    t.Description,
                    t.DueDate,
                    Status = t.status,
                    Priority = t.priority,
                    CategoryName = t.Category.Name
                })
                .ToList();

            totalPages = (int)Math.Ceiling((double)tasks.Count / pageSize);
            var paginatedData = tasks
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dataGridView1.DataSource = paginatedData;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            UpdatePaginationButtons();
        }

        public void LoadComboBoxValuesToDataGrid()
        {
            StatuscomboBox.DataSource = Enum.GetValues(typeof(Task_Status));
            PrioritycomboBox.DataSource = Enum.GetValues(typeof(Task_Priority));
            FilterByStatuscomboBox.DataSource = Enum.GetValues(typeof(Task_Status));
            FilterByPrioritycomboBox.DataSource = Enum.GetValues(typeof(Task_Priority));


            var category = AppContext.Categories
                                .Select(c => new
                                {
                                    c.Id,
                                    c.Name
                                })
                                .ToList();
            CategorycomboBox.DataSource = category;
            CategorycomboBox.DisplayMember = "Name";
            CategorycomboBox.ValueMember = "Id";
        }

        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            var statusValue = row.Cells["Status"].Value;
            var dueDateValue = row.Cells["DueDate"].Value;

            if (dueDateValue != null && DateTime.TryParse(dueDateValue.ToString(), out DateTime dueDate))
            {
                if (dueDate < DateTime.Now && statusValue is Task_Status stat && stat != Task_Status.Completed)
                {
                    row.DefaultCellStyle.BackColor = Color.Red; // Overdue tasks
                    return; // Exit early to avoid overriding with other colors
                }
            }

            if (statusValue != null && statusValue is Task_Status status)
            {
                switch (status)
                {
                    case Task_Status.Completed:
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case Task_Status.InProgress:
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case Task_Status.Pending:
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        #endregion




        private void FilterByPriorityBtn_Click(object sender, EventArgs e)
        {
            if (FilterByPrioritycomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a priority to filter.");
                return;
            }

            currentMode = "FilterByPriority";
            currentPage = 1; // Reset pagination to first page
            LoadDataGridBasedOnMode();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
            this.Close();
        }
    }
}