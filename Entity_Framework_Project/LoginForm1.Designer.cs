namespace Entity_Framework_Project
{
    partial class LoginForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm1));
            label3 = new Label();
            SignUpBtn = new Button();
            EmailTxt = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            UsernameTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Bisque;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(198, 395);
            label3.Name = "label3";
            label3.Size = new Size(277, 20);
            label3.TabIndex = 13;
            label3.Text = "Not Registered? you can regester here";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.Bisque;
            SignUpBtn.FlatStyle = FlatStyle.Popup;
            SignUpBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SignUpBtn.Location = new Point(255, 430);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(180, 42);
            SignUpBtn.TabIndex = 12;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click_1;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(227, 162);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(308, 27);
            EmailTxt.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(123, 165);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Bisque;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn.Location = new Point(255, 236);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(180, 42);
            LoginBtn.TabIndex = 9;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(227, 108);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(308, 27);
            UsernameTxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(106, 108);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // LoginForm1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(685, 505);
            Controls.Add(label3);
            Controls.Add(SignUpBtn);
            Controls.Add(EmailTxt);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(UsernameTxt);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "LoginForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button SignUpBtn;
        private TextBox EmailTxt;
        private Label label2;
        private Button LoginBtn;
        private TextBox UsernameTxt;
        private Label label1;
    }
}