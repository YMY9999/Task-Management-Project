using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Entity_Framework_Project
{
    public partial class ReportForm : Form
    {
        public ReportForm(string reportText, int completedCount, int pendingCount, int inProgressCount, int totalTasks)
        {
            InitializeComponent();
            SetupReportUI(reportText, completedCount, pendingCount, inProgressCount, totalTasks);
        }

        private void SetupReportUI(string reportText, int completedCount, int pendingCount, int inProgressCount, int totalTasks)
        {
            // Split container with vertical orientation for side-by-side layout
            SplitContainer splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical, // Vertical split: chart on left, text on right
                SplitterDistance = 80 // Width of the chart area (adjust as needed)
            };

            // Chart setup
            Chart reportChart = new Chart
            {
                Dock = DockStyle.Fill
            };
            ChartArea chartArea = new ChartArea();
            Series series = new Series
            {
                ChartType = SeriesChartType.Pie
            };

            // Add data points to the pie chart
            series.Points.AddXY("Completed", completedCount);
            series.Points.AddXY("Pending", pendingCount);
            series.Points.AddXY("In Progress", inProgressCount);

            // Customize chart appearance
            series.Points[0].Color = System.Drawing.Color.LightGreen; // Completed
            series.Points[1].Color = System.Drawing.Color.Yellow;     // Pending
            series.Points[2].Color = System.Drawing.Color.Orange;     // In Progress
            reportChart.Series.Add(series);
            reportChart.ChartAreas.Add(chartArea);
            reportChart.Titles.Add($"Task Distribution (Total: {totalTasks})");
            reportChart.Legends.Add(new Legend());

            // Use the existing RichTextBox from the designer
            reportTextBox.Text = reportText;
            reportTextBox.Dock = DockStyle.Fill;

            // Move the existing closeButton to the bottom of the right panel
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Height = 30;

            // Add controls to split container
            splitContainer.Panel1.Controls.Add(reportChart); // Left: chart
            splitContainer.Panel2.Controls.Add(reportTextBox); // Right: text
            splitContainer.Panel2.Controls.Add(closeButton);   // Right: button below text

            // Form setup
            this.Controls.Add(splitContainer);
            this.Text = "Task Status Report";
            this.Size = new System.Drawing.Size(1000, 600); // Wider form for side-by-side
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close the form when the button is clicked

        }
    }
}