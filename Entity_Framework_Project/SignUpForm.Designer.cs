namespace Entity_Framework_Project
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            EmailSignUpTxt = new TextBox();
            label2 = new Label();
            UsernameSignUpTxt = new TextBox();
            label1 = new Label();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // EmailSignUpTxt
            // 
            EmailSignUpTxt.Location = new Point(220, 253);
            EmailSignUpTxt.Name = "EmailSignUpTxt";
            EmailSignUpTxt.Size = new Size(308, 27);
            EmailSignUpTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(116, 256);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // UsernameSignUpTxt
            // 
            UsernameSignUpTxt.Location = new Point(220, 170);
            UsernameSignUpTxt.Name = "UsernameSignUpTxt";
            UsernameSignUpTxt.Size = new Size(308, 27);
            UsernameSignUpTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(99, 173);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Bisque;
            RegisterBtn.FlatStyle = FlatStyle.Popup;
            RegisterBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegisterBtn.Location = new Point(246, 363);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(180, 42);
            RegisterBtn.TabIndex = 9;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(685, 505);
            Controls.Add(RegisterBtn);
            Controls.Add(EmailSignUpTxt);
            Controls.Add(label2);
            Controls.Add(UsernameSignUpTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailSignUpTxt;
        private Label label2;
        private TextBox UsernameSignUpTxt;
        private Label label1;
        private Button RegisterBtn;
    }
}