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
    public partial class EmployeeProfileView : Form
    {
        private int employeeId;
        public EmployeeProfileView()
        {
            InitializeComponent();
        }
        public EmployeeProfileView(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            //LoadEmployeeProfile(employeeId);
        }

        private void EmployeeProfileView_Load(object sender, EventArgs e)
        {
            string query = $@"SELECT U.UserID,U.FullName, U.Password, U.Email, U.PhoneNumber,U.Address,U.Gender,U.JoinDate,E.EmployeeType,E.Salary
                          FROM [User] U JOIN EmployeeDetails E ON U.UserID=E.EmployeeID
                          Where U.UserID={employeeId}";
            DataTable dt = DataAccess.GetData(query);
            if(dt != null && dt.Rows.Count>0)
            {
                txtId.Text = dt.Rows[0]["UserID"].ToString();
                txtName.Text = dt.Rows[0]["FullName"].ToString();
                txtPass.Text = dt.Rows[0]["Password"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPhn.Text = dt.Rows[0]["PhoneNumber"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                string gender = dt.Rows[0]["Gender"].ToString();
                if (gender == "Male")
                {
                   rbtnMale.Checked=true;
                   rbtnFemale.Checked = false;
                }
                else if (gender =="Female")
                {
                    rbtnFemale.Checked = true;
                    rbtnMale.Checked = false;
                }
                else
                {
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                }
                txtJoin.Text = Convert.ToDateTime(dt.Rows[0]["JoinDate"]).ToString("dd/MM/yyyy");
                txtType.Text = dt.Rows[0]["EmployeeType"].ToString();
                txtSalary.Text = dt.Rows[0]["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("Employee profile not found.");
            }
        }
        bool isEditMode = false;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                txtName.ReadOnly = false;
                txtPass.ReadOnly = false;
                txtPhn.ReadOnly = false;
                txtAddress.ReadOnly = false;
                rbtnMale.Enabled = true;
                rbtnFemale.Enabled = true;
                btnEdit.Text = "Update";
                btnEdit.BackColor = Color.SteelBlue;
                isEditMode = true;
            }
            else
            {
                string name = txtName.Text;
                string pass = txtPass.Text;
                string phn = txtPhn.Text;
                string address = txtAddress.Text;
                string gender = "";
                if (rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else if (rbtnFemale.Checked)
                {
                    gender = "Female";
                }
                if(name==string.Empty || pass == string.Empty || phn == string.Empty || address == string.Empty|| gender==string.Empty)
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }
                string updateUser = $@"
            UPDATE [User]
            SET FullName = '{name}',
                Password = '{pass}',
                PhoneNumber = '{phn}',
                Address = '{address}',
                Gender = '{gender}'
            WHERE UserID = {employeeId};";

                if(DataAccess.Execute(updateUser))
                {
                    MessageBox.Show("Profile updated successfully.");
                    txtName.ReadOnly = true;
                    txtPass.ReadOnly = true;
                    txtPhn.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;
                    btnEdit.Text = "Edit";
                    btnEdit.BackColor = Color.LightSeaGreen;
                    isEditMode = false;
                    if (txtType.Text == "Doctor")
                    {


                        DoctorForm doctorForm = new DoctorForm();
                        doctorForm.Show();
                        this.Hide();
                    }
                    else if(txtType.Text == "Staff")
                    {
                        EmployeeAdmin admin = new EmployeeAdmin();
                        admin.Show();
                        this.Hide();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Failed to update profile. Please try again.");
                }
            }
        }
    }
}
