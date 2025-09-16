using Entity_Framework_Project.Context;
using Entity_Framework_Project.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class SignUpForm : Form
    {
        private readonly AppDbContext Context;
        User newuser;

        public SignUpForm()
        {
            InitializeComponent();
            Context = new AppDbContext();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameSignUpTxt.Text.Trim();
            string email = EmailSignUpTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Context.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("Email is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newuser = new User
            {
                Name = username,
                Email = email,
            };

            Context.Users.Add(newuser);
            Context.SaveChanges();
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
