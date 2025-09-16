namespace Entity_Framework_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TitleTxt = new TextBox();
            DescriptionTxt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            StatuscomboBox = new ComboBox();
            PrioritycomboBox = new ComboBox();
            AddBtn = new Button();
            DeleteBtn = new Button();
            ClearBtn = new Button();
            EditBtn = new Button();
            FilterByStatusBtn = new Button();
            FilterByStatuscomboBox = new ComboBox();
            button1 = new Button();
            CategorycomboBox = new ComboBox();
            CategoryLable = new Label();
            GroupbyPriorityBtn = new Button();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            CheckOverdueBtn = new Button();
            AvgCompletionTimeBtn = new Button();
            GenerateReportBtn = new Button();
            FilterByPrioritycomboBox = new ComboBox();
            FilterByPriorityBtn = new Button();
            LogoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1491, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += FillSpaceWithValuesToEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(37, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 27);
            label1.TabIndex = 1;
            label1.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(532, 22);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(38, 176);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 3;
            label3.Text = "DueDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(38, 97);
            label4.Name = "label4";
            label4.Size = new Size(67, 27);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Bisque;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(532, 103);
            label5.Name = "label5";
            label5.Size = new Size(77, 27);
            label5.TabIndex = 5;
            label5.Text = "Priority";
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(148, 22);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(317, 30);
            TitleTxt.TabIndex = 6;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(662, 22);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(312, 30);
            DescriptionTxt.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 176);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(317, 30);
            dateTimePicker1.TabIndex = 8;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(148, 93);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(317, 31);
            StatuscomboBox.TabIndex = 9;
            // 
            // PrioritycomboBox
            // 
            PrioritycomboBox.FormattingEnabled = true;
            PrioritycomboBox.Location = new Point(662, 99);
            PrioritycomboBox.Name = "PrioritycomboBox";
            PrioritycomboBox.Size = new Size(312, 31);
            PrioritycomboBox.TabIndex = 10;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Bisque;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(1012, 22);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(229, 67);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "Add Task";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Bisque;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(1278, 22);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(229, 67);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "Delete Task";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Bisque;
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.Location = new Point(1273, 136);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(232, 67);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Bisque;
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(1012, 141);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(229, 67);
            EditBtn.TabIndex = 14;
            EditBtn.Text = "Edit Task";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // FilterByStatusBtn
            // 
            FilterByStatusBtn.BackColor = Color.Bisque;
            FilterByStatusBtn.FlatStyle = FlatStyle.Popup;
            FilterByStatusBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            FilterByStatusBtn.Location = new Point(1012, 626);
            FilterByStatusBtn.Name = "FilterByStatusBtn";
            FilterByStatusBtn.Size = new Size(282, 32);
            FilterByStatusBtn.TabIndex = 15;
            FilterByStatusBtn.Text = "Filter By Status";
            FilterByStatusBtn.UseVisualStyleBackColor = false;
            FilterByStatusBtn.Click += FilterByStatusBtn_Click;
            // 
            // FilterByStatuscomboBox
            // 
            FilterByStatuscomboBox.FormattingEnabled = true;
            FilterByStatuscomboBox.Location = new Point(1318, 626);
            FilterByStatuscomboBox.Name = "FilterByStatuscomboBox";
            FilterByStatuscomboBox.Size = new Size(187, 31);
            FilterByStatuscomboBox.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(326, 503);
            button1.Name = "button1";
            button1.Size = new Size(263, 67);
            button1.TabIndex = 17;
            button1.Text = "Sort By DueDate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(662, 176);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(312, 31);
            CategorycomboBox.TabIndex = 19;
            // 
            // CategoryLable
            // 
            CategoryLable.AutoSize = true;
            CategoryLable.BackColor = Color.Bisque;
            CategoryLable.BorderStyle = BorderStyle.Fixed3D;
            CategoryLable.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            CategoryLable.Location = new Point(532, 181);
            CategoryLable.Name = "CategoryLable";
            CategoryLable.Size = new Size(92, 27);
            CategoryLable.TabIndex = 18;
            CategoryLable.Text = "Category";
            // 
            // GroupbyPriorityBtn
            // 
            GroupbyPriorityBtn.BackColor = Color.Bisque;
            GroupbyPriorityBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GroupbyPriorityBtn.ForeColor = Color.Black;
            GroupbyPriorityBtn.Location = new Point(326, 604);
            GroupbyPriorityBtn.Name = "GroupbyPriorityBtn";
            GroupbyPriorityBtn.Size = new Size(266, 67);
            GroupbyPriorityBtn.TabIndex = 20;
            GroupbyPriorityBtn.Text = "Group tasks by priority";
            GroupbyPriorityBtn.UseVisualStyleBackColor = false;
            GroupbyPriorityBtn.Click += GroupbyPriorityBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Bisque;
            NextBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NextBtn.Location = new Point(772, 467);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(68, 33);
            NextBtn.TabIndex = 21;
            NextBtn.Text = ">>";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PrevBtn
            // 
            PrevBtn.BackColor = Color.Bisque;
            PrevBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PrevBtn.Location = new Point(679, 467);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(68, 33);
            PrevBtn.TabIndex = 22;
            PrevBtn.Text = "<<";
            PrevBtn.UseVisualStyleBackColor = false;
            PrevBtn.Click += PrevBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Bisque;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            SearchBtn.Location = new Point(1012, 542);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(282, 31);
            SearchBtn.TabIndex = 23;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.BackColor = SystemColors.HighlightText;
            SearchTxt.Location = new Point(1318, 542);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(187, 30);
            SearchTxt.TabIndex = 24;
            // 
            // CheckOverdueBtn
            // 
            CheckOverdueBtn.BackColor = Color.Bisque;
            CheckOverdueBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CheckOverdueBtn.ForeColor = Color.Black;
            CheckOverdueBtn.Location = new Point(13, 604);
            CheckOverdueBtn.Name = "CheckOverdueBtn";
            CheckOverdueBtn.Size = new Size(268, 67);
            CheckOverdueBtn.TabIndex = 26;
            CheckOverdueBtn.Text = "Check OverDue Tasks";
            CheckOverdueBtn.UseVisualStyleBackColor = false;
            CheckOverdueBtn.Click += CheckOverdueBtn_Click;
            // 
            // AvgCompletionTimeBtn
            // 
            AvgCompletionTimeBtn.BackColor = Color.Bisque;
            AvgCompletionTimeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AvgCompletionTimeBtn.ForeColor = Color.Black;
            AvgCompletionTimeBtn.Location = new Point(16, 503);
            AvgCompletionTimeBtn.Name = "AvgCompletionTimeBtn";
            AvgCompletionTimeBtn.Size = new Size(266, 67);
            AvgCompletionTimeBtn.TabIndex = 27;
            AvgCompletionTimeBtn.Text = "Average Task Completion Time";
            AvgCompletionTimeBtn.UseVisualStyleBackColor = false;
            AvgCompletionTimeBtn.Click += AvgCompletionTimeBtn_Click;
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.BackColor = Color.Bisque;
            GenerateReportBtn.FlatStyle = FlatStyle.Popup;
            GenerateReportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReportBtn.Location = new Point(193, 711);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(221, 67);
            GenerateReportBtn.TabIndex = 28;
            GenerateReportBtn.Text = "Generate Report";
            GenerateReportBtn.UseVisualStyleBackColor = false;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // FilterByPrioritycomboBox
            // 
            FilterByPrioritycomboBox.FormattingEnabled = true;
            FilterByPrioritycomboBox.Location = new Point(1318, 711);
            FilterByPrioritycomboBox.Name = "FilterByPrioritycomboBox";
            FilterByPrioritycomboBox.Size = new Size(187, 31);
            FilterByPrioritycomboBox.TabIndex = 30;
            // 
            // FilterByPriorityBtn
            // 
            FilterByPriorityBtn.BackColor = Color.Bisque;
            FilterByPriorityBtn.FlatStyle = FlatStyle.Popup;
            FilterByPriorityBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            FilterByPriorityBtn.Location = new Point(1012, 711);
            FilterByPriorityBtn.Name = "FilterByPriorityBtn";
            FilterByPriorityBtn.Size = new Size(282, 32);
            FilterByPriorityBtn.TabIndex = 29;
            FilterByPriorityBtn.Text = "Filter By Priority";
            FilterByPriorityBtn.UseVisualStyleBackColor = false;
            FilterByPriorityBtn.Click += FilterByPriorityBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Coral;
            LogoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(643, 730);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(221, 67);
            LogoutBtn.TabIndex = 31;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1521, 811);
            Controls.Add(LogoutBtn);
            Controls.Add(FilterByPrioritycomboBox);
            Controls.Add(FilterByPriorityBtn);
            Controls.Add(GenerateReportBtn);
            Controls.Add(AvgCompletionTimeBtn);
            Controls.Add(CheckOverdueBtn);
            Controls.Add(SearchTxt);
            Controls.Add(SearchBtn);
            Controls.Add(PrevBtn);
            Controls.Add(NextBtn);
            Controls.Add(GroupbyPriorityBtn);
            Controls.Add(CategorycomboBox);
            Controls.Add(CategoryLable);
            Controls.Add(button1);
            Controls.Add(FilterByStatuscomboBox);
            Controls.Add(FilterByStatusBtn);
            Controls.Add(EditBtn);
            Controls.Add(ClearBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(PrioritycomboBox);
            Controls.Add(StatuscomboBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(DescriptionTxt);
            Controls.Add(TitleTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ForeColor = Color.Black;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TitleTxt;
        private TextBox DescriptionTxt;
        private DateTimePicker dateTimePicker1;
        private ComboBox StatuscomboBox;
        private ComboBox PrioritycomboBox;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private Button EditBtn;
        private Button FilterByStatusBtn;
        private ComboBox FilterByStatuscomboBox;
        private Button button1;
        private ComboBox CategorycomboBox;
        private Label CategoryLable;
        private Button GroupbyPriorityBtn;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Button CheckOverdueBtn;
        private Button AvgCompletionTimeBtn;
        private Button GenerateReportBtn;
        private ComboBox FilterByPrioritycomboBox;
        private Button FilterByPriorityBtn;
        private Button LogoutBtn;
    }
}
