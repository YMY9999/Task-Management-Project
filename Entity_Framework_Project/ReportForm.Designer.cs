namespace Entity_Framework_Project
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            reportTextBox = new RichTextBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // reportTextBox
            // 
            reportTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportTextBox.BackColor = Color.Bisque;
            reportTextBox.Location = new Point(36, 21);
            reportTextBox.Name = "reportTextBox";
            reportTextBox.ReadOnly = true;
            reportTextBox.Size = new Size(1043, 516);
            reportTextBox.TabIndex = 0;
            reportTextBox.Text = "";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Bisque;
            closeButton.FlatStyle = FlatStyle.Popup;
            closeButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(440, 552);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(115, 42);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click_1;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1117, 606);
            Controls.Add(closeButton);
            Controls.Add(reportTextBox);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generated Report";
            ResumeLayout(false);
        }

        #endregion
        public RichTextBox reportTextBox;
        private Button closeButton;
    }
}