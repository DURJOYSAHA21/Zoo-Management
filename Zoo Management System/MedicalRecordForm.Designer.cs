namespace ZooManagementSystem
{
    partial class MedicalRecordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAnimalID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNextVisitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTreatment = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpTreatmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNotes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNextVisitDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMedicine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTreatment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTreatmentDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();

            // Common positioning variables
            int labelWidth = 180;
            int labelXPosition = 30;
            int controlXPosition = labelXPosition + labelWidth + 20;
            int controlWidth = 540;

            // guna2BorderlessForm1
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;

            // guna2Panel1 (Header Panel)
            this.guna2Panel1.Controls.Add(this.lblAnimalID);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 120);
            this.guna2Panel1.TabIndex = 0;

            // lblAnimalID
            this.lblAnimalID.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnimalID.ForeColor = System.Drawing.Color.White;
            this.lblAnimalID.Location = new System.Drawing.Point(550, 70);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(220, 30);
            this.lblAnimalID.TabIndex = 1;
            this.lblAnimalID.Text = "Animal ID:";
            this.lblAnimalID.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            // label1 (Title)
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical Record Form";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            // guna2Panel2 (Main Content Panel)
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.txtNotes);
            this.guna2Panel2.Controls.Add(this.txtStatus);
            this.guna2Panel2.Controls.Add(this.dtpNextVisitDate);
            this.guna2Panel2.Controls.Add(this.txtMedicine);
            this.guna2Panel2.Controls.Add(this.txtTreatment);
            this.guna2Panel2.Controls.Add(this.dtpTreatmentDate);
            this.guna2Panel2.Controls.Add(this.lblStatus);
            this.guna2Panel2.Controls.Add(this.lblNotes);
            this.guna2Panel2.Controls.Add(this.lblNextVisitDate);
            this.guna2Panel2.Controls.Add(this.lblMedicine);
            this.guna2Panel2.Controls.Add(this.lblTreatment);
            this.guna2Panel2.Controls.Add(this.lblTreatmentDate);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 120);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(30);
            this.guna2Panel2.Size = new System.Drawing.Size(800, 705);
            this.guna2Panel2.TabIndex = 1;

            // Treatment Date Section
            this.lblTreatmentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTreatmentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTreatmentDate.Location = new System.Drawing.Point(labelXPosition, 100);
            this.lblTreatmentDate.Name = "lblTreatmentDate";
            this.lblTreatmentDate.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblTreatmentDate.TabIndex = 0;
            this.lblTreatmentDate.Text = "Treatment Date:";
            this.lblTreatmentDate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.dtpTreatmentDate.Animated = true;
            this.dtpTreatmentDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dtpTreatmentDate.BorderRadius = 8;
            this.dtpTreatmentDate.Checked = true;
            this.dtpTreatmentDate.Enabled = false;
            this.dtpTreatmentDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dtpTreatmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTreatmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTreatmentDate.Location = new System.Drawing.Point(controlXPosition, 100);
            this.dtpTreatmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTreatmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTreatmentDate.Name = "dtpTreatmentDate";
            this.dtpTreatmentDate.Size = new System.Drawing.Size(controlWidth, 40);
            this.dtpTreatmentDate.TabIndex = 0;
            this.dtpTreatmentDate.Value = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);

            // Treatment Section
            this.lblTreatment.BackColor = System.Drawing.Color.Transparent;
            this.lblTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTreatment.Location = new System.Drawing.Point(labelXPosition, 182);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblTreatment.TabIndex = 1;
            this.lblTreatment.Text = "Treatment:";
            this.lblTreatment.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.txtTreatment.Animated = true;
            this.txtTreatment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtTreatment.BorderRadius = 8;
            this.txtTreatment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTreatment.DefaultText = "";
            this.txtTreatment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTreatment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTreatment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTreatment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTreatment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTreatment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTreatment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTreatment.Location = new System.Drawing.Point(controlXPosition, 182);
            this.txtTreatment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.PlaceholderText = "Enter treatment details";
            this.txtTreatment.SelectedText = "";
            this.txtTreatment.Size = new System.Drawing.Size(controlWidth, 40);
            this.txtTreatment.TabIndex = 1;

            // Medicine Section
            this.lblMedicine.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMedicine.Location = new System.Drawing.Point(labelXPosition, 265);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblMedicine.TabIndex = 2;
            this.lblMedicine.Text = "Medicine:";
            this.lblMedicine.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.txtMedicine.Animated = true;
            this.txtMedicine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtMedicine.BorderRadius = 8;
            this.txtMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicine.DefaultText = "";
            this.txtMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicine.Location = new System.Drawing.Point(controlXPosition, 265);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMedicine.Multiline = true;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.PlaceholderText = "Enter prescribed medicines";
            this.txtMedicine.SelectedText = "";
            this.txtMedicine.Size = new System.Drawing.Size(controlWidth, 40);
            this.txtMedicine.TabIndex = 2;

            // Next Visit Date Section
            this.lblNextVisitDate.BackColor = System.Drawing.Color.Transparent;
            this.lblNextVisitDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNextVisitDate.Location = new System.Drawing.Point(labelXPosition, 339);
            this.lblNextVisitDate.Name = "lblNextVisitDate";
            this.lblNextVisitDate.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblNextVisitDate.TabIndex = 3;
            this.lblNextVisitDate.Text = "Next Visit Date:";
            this.lblNextVisitDate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.dtpNextVisitDate.Animated = true;
            this.dtpNextVisitDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dtpNextVisitDate.BorderRadius = 8;
            this.dtpNextVisitDate.Checked = true;
            this.dtpNextVisitDate.FillColor = System.Drawing.Color.White;
            this.dtpNextVisitDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNextVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextVisitDate.Location = new System.Drawing.Point(controlXPosition, 339);
            this.dtpNextVisitDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNextVisitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNextVisitDate.Name = "dtpNextVisitDate";
            this.dtpNextVisitDate.Size = new System.Drawing.Size(controlWidth, 40);
            this.dtpNextVisitDate.TabIndex = 3;
            this.dtpNextVisitDate.Value = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);

            // Notes Section
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(labelXPosition, 422);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.txtNotes.Animated = true;
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(controlXPosition, 422);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Enter any additional notes";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(controlWidth, 74);
            this.txtNotes.TabIndex = 4;

            // Status Section
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(labelXPosition, 538);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(labelWidth, 38);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;

            this.txtStatus.Animated = true;
            this.txtStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.txtStatus.BorderRadius = 8;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(controlXPosition, 538);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "Enter animal status";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(controlWidth, 40);
            this.txtStatus.TabIndex = 5;

            // guna2Panel3 (Footer Panel with buttons)
            this.guna2Panel3.Controls.Add(this.btnCancel);
            this.guna2Panel3.Controls.Add(this.btnSave);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 825);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel3.TabIndex = 2;

            // Cancel Button
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(600, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Save Button
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(430, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // MedicalRecordForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 925);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "MedicalRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Record";
            this.Load += new System.EventHandler(this.MedicalRecordForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNextVisitDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMedicine;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTreatment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTreatmentDate;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicine;
        private Guna.UI2.WinForms.Guna2TextBox txtTreatment;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTreatmentDate;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNextVisitDate;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAnimalID;
    }
}