using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ZooManagementSystem
{
    
        public partial class MedicalRecordForm : Form
        {
            public MedicalRecordForm()
            {
                InitializeComponent();
               
            }

            int UserID;
            int AnimalID;
            DateTime checkupDate;
            int? checkupID = null;

            public void SetUserID(int UserID)
            {
                this.UserID = UserID;
            }

            public void SetAnimalID(int AnimalID)
            {
                this.AnimalID = AnimalID;
                lblAnimalID.Text = $"Animal ID: {AnimalID}";
            }

            public void SetCheckupDate(DateTime checkupDate)
            {
                this.checkupDate = checkupDate;
            }

            public void SetCheckupID(int checkupID)
            {
                this.checkupID = checkupID;
            }

            private void MedicalRecordForm_Load(object sender, EventArgs e)
            {
                if (checkupID != null)
                {
                    dtpTreatmentDate.Value = checkupDate;
                }
                else
                {
                    dtpTreatmentDate.Value = DateTime.Now.Date;
                }

                dtpTreatmentDate.Enabled = false;
                dtpNextVisitDate.MinDate = DateTime.Now.Date;
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                if (!ValidateForm())
                    return;

                try
                {
                string query =
                    $"INSERT INTO MedicalRecord VALUES ({AnimalID}, {UserID},'{dtpTreatmentDate.Value.Date}', '{txtTreatment.Text}', '{txtMedicine.Text}', '{dtpNextVisitDate.Value.Date}', '{txtNotes.Text}', '{txtStatus.Text}',null)";
                      
                    if (DataAccess.Execute(query))
                    {
                        Guna.UI2.WinForms.MessageDialog.Show(this, "Medical record saved successfully.", "Success",
                            MessageDialogButtons.OK, MessageDialogIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Failed to save medical record.");
                    }
                }
                catch (Exception ex)
                {
                    Guna.UI2.WinForms.MessageDialog.Show(this, $"Error: {ex.Message}", "Error",
                        MessageDialogButtons.OK, MessageDialogIcon.Error);
                }
            }

            private bool ValidateForm()
            {
                if (string.IsNullOrWhiteSpace(txtTreatment.Text))
                {
                    ShowValidationError("Please enter a treatment.", txtTreatment);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtStatus.Text))
                {
                    ShowValidationError("Please enter a status.", txtStatus);
                    return false;
                }

                if (dtpNextVisitDate.Value < DateTime.Now.Date)
                {
                    ShowValidationError("Next visit date cannot be in the past.", dtpNextVisitDate);
                    return false;
                }

                return true;
            }

            private void ShowValidationError(string message, Control control)
            {
                Guna.UI2.WinForms.MessageDialog.Show(this, message, "Validation Error",
                    MessageDialogButtons.OK, MessageDialogIcon.Warning);
                control.Focus();
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
