
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassLogAdmin.Clear();
                txtIdLogAdmin.Clear();
                txtPassLogAdmin.UseSystemPasswordChar = false;
                btnShowPass.Text = "Show";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = txtIdLogAdmin.Text;
                string pass = txtPassLogAdmin.Text;
                btnClear.PerformClick();

                if (userInput == "" || pass == "")
                {
                    MessageBox.Show("Please enter your ID and Password.");
                    //btnClear.PerformClick();
                    return;
                }

                if (!int.TryParse(userInput, out int userId))
                {
                    MessageBox.Show("User ID must be a number.");
                    //btnClear.PerformClick();
                    return;
                }

                string query = $@"
                SELECT * FROM [User] 
                WHERE UserID = {userId} AND Password = '{pass}' AND RoleID = 1";

                var data = DataAccess.GetData(query);
                //btnClear.PerformClick();

                if (data != null && data.Rows.Count == 1)
                {
                    MessageBox.Show("Welcome, Admin!");
                    AdminHome adminHome = new AdminHome();
                    adminHome.SetUserId(userId);
                    adminHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials or not an admin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassLogAdmin.Text == "")
                    return;

                if (btnShowPass.Text == "Show")
                {
                    txtPassLogAdmin.UseSystemPasswordChar = true;
                    btnShowPass.Text = "Hide";
                }
                else
                {
                    txtPassLogAdmin.UseSystemPasswordChar = false;
                    btnShowPass.Text = "Show";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass1 forgotPassForm = new ForgotPass1();
            forgotPassForm.Show();
        }
    }
}
