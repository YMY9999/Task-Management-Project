using Entity_Framework_Project.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Entity_Framework_Project
{

    public partial class LoginForm1 : Form
    {
         private readonly AppDbContext Context; 

        public LoginForm1()
        {
            InitializeComponent();
            Context = new AppDbContext();
        }
        public static class SessionManager
        {
            public static int LoggedInUserId { get; set; }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string username = UsernameTxt.Text;
            string email = EmailTxt.Text;
            var user = Context.Users.FirstOrDefault(e => e.Name == username && e.Email == email);
            if (user != null)
            {
                SessionManager.LoggedInUserId = user.Id;
                MessageBox.Show("Login Successful!");
                Form1 form1 = new Form1(SessionManager.LoggedInUserId);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void SignUpBtn_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
