using Microsoft.SqlServer.Server;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using ZooManagement.Properties;

namespace ZooManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true; //keyevent capture kore,textbox focus thakleo kaj kore
            this.KeyDown += btnLogin_KeyDown; //call and run
            labelDummy.TabStop = false;
            this.Shown += LoginForm_Shown;
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = labelDummy;
        }


        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Shift && e.KeyCode==Keys.A)
            {
                MessageBox.Show("Admin login mode activated. Please enter admin credentials.");
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userInput = txtEmailorID.Text;
            string pass = txtPassLog.Text;

            if (userInput == "" || pass == "" || txtEmailorID.Text == "Enter Email or ID" || txtPassLog.Text == "Enter Password")
            {
                MessageBox.Show("Please enter Email/UserID and Password.");
                return;
            }

            string query;

            if (int.TryParse(userInput, out int userId))
            {
                query = $@"
                        SELECT u.*, r.RoleName 
                        FROM [User] u 
                        JOIN Role r ON u.RoleID = r.RoleID 
                        WHERE u.UserID = {userId} AND u.Password = '{pass}'";
            }
            else
            {
                query = $@"
                        SELECT u.*, r.RoleName 
                        FROM [User] u 
                        JOIN Role r ON u.RoleID = r.RoleID 
                        WHERE u.Email = '{userInput}' AND u.Password = '{pass}'";
            }
            var data = DataAccess.GetData(query);

            if (data == null || data.Rows.Count != 1)
            {
                MessageBox.Show("Invalid login credentials.");
                btnClear.PerformClick();
                return;
            }

            int roleId = Convert.ToInt32(data.Rows[0]["RoleID"]);
            userId = Convert.ToInt32(data.Rows[0]["UserID"]);
            btnClear.PerformClick();
            string employeeType = " ";
        
            if (roleId == 2)
            {

                DataTable dtEmp = DataAccess.GetData($"SELECT EmployeeType FROM EmployeeDetails WHERE EmployeeID = {userId}");
                if (dtEmp.Rows.Count == 1)
                {
                    employeeType = dtEmp.Rows[0]["EmployeeType"].ToString();
                }
                else
                {
                    MessageBox.Show("Role not found for this employee.");
                    return;
                }
               
                
            }
            if(roleId ==2 && employeeType =="Doctor")
            {

                DoctorForm doctorForm = new DoctorForm();
                doctorForm.SetUserID(userId);
                doctorForm.Show();
                this.Hide();

            }
            else if (roleId == 2 && employeeType == "Staff")
            {

                EmployeeFrame employeeForm = new EmployeeFrame();
                employeeForm.SetUserID(userId);
                employeeForm.Show();
                this.Hide();

            }
            else if (roleId == 3)
            {
                userId = Convert.ToInt32(data.Rows[0]["UserID"]);
                string visitorQuery = $"SELECT VisitorID FROM VisitorDetails WHERE VisitorID = {userId}";
                DataTable visitorData = DataAccess.GetData(visitorQuery);

                if (visitorData == null || visitorData.Rows.Count == 0)
                {
                    MessageBox.Show("Visitor profile not found.");
                    return;
                }
                int visitorId = Convert.ToInt32(visitorData.Rows[0]["VisitorID"]);
                MessageBox.Show("Welcome, Visitor!");
                visitorHome mainForm = new visitorHome(visitorId);
                mainForm.Show();
                //Purchase
                //MessageBox.Show("Hello");
                //PickDateTime pickDateTimeForm = new PickDateTime(visitorId,userId);
                //pickDateTimeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unauthorized access.");
               // btnClear.PerformClick();
            }
        }

        private void txtEmailorID_Enter(object sender, EventArgs e)
        {
            if(txtEmailorID.Text == "Enter Email or ID")
            {
                txtEmailorID.Text = "";
                txtEmailorID.ForeColor = Color.Black;
            }
        }

        private void txtPassLog_Enter(object sender, EventArgs e)
        {
            if (txtPassLog.Text == "Enter Password")
            {
                txtPassLog.Text = "";
                txtPassLog.ForeColor = Color.Black;
                //txtPassLog.UseSystemPasswordChar = true;
            }
        }

        private void txtEmailorID_Leave(object sender, EventArgs e)
        {
            if(txtEmailorID.Text == "")
            {
                txtEmailorID.Text = "Enter Email or ID";
                txtEmailorID.ForeColor = Color.Gray;
            }
        }

        private void txtPassLog_Leave(object sender, EventArgs e)
        {
            if(txtPassLog.Text == "")
            {
                txtPassLog.Text = "Enter Password";
                txtPassLog.ForeColor = Color.Gray;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassLog.Text = "Enter Password";
            txtPassLog.ForeColor = Color.Gray;
            txtEmailorID.Text = "Enter Email or ID";
            txtEmailorID.ForeColor = Color.Gray;
            btnShowPass.Text = "Hide";
            txtPassLog.UseSystemPasswordChar = true;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassLog.Text == "Enter Password")
            {
                return;
            }
            else if (btnShowPass.Text == "Hide")
            {
                txtPassLog.UseSystemPasswordChar = false;
                btnShowPass.Text = "Show";
            }
            else
            {
                txtPassLog.UseSystemPasswordChar = true;
                btnShowPass.Text = "Hide";
            }
        }
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass1 forgotPassForm = new ForgotPass1();
            forgotPassForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }
    }
}
