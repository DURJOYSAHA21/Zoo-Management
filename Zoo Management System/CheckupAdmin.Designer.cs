namespace ZooManagementSystem
{
    partial class CheckupAdmin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCheckupDetails = new System.Windows.Forms.DataGridView();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewAnimal = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCheckupDetails = new System.Windows.Forms.Button();
            this.btnMedicalRecord = new System.Windows.Forms.Button();
            this.btnWorkSchedule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbHealthCondition = new System.Windows.Forms.ComboBox();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckupID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCheckupDate = new System.Windows.Forms.DateTimePicker();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckupDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCheckupDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2384, 1235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvCheckupDetails
            // 
            this.dgvCheckupDetails.AllowUserToAddRows = false;
            this.dgvCheckupDetails.AllowUserToDeleteRows = false;
            this.dgvCheckupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckupDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalName,
            this.AnimalID,
            this.Species,
            this.DoctorNames,
            this.CheckupDate,
            this.HealthCondition,
            this.Weight,
            this.Temperature,
            this.HeartRate,
            this.Notes,
            this.DoctorID,
            this.CheckupID});
            this.dgvCheckupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckupDetails.Location = new System.Drawing.Point(453, 153);
            this.dgvCheckupDetails.Name = "dgvCheckupDetails";
            this.dgvCheckupDetails.ReadOnly = true;
            this.dgvCheckupDetails.RowHeadersWidth = 72;
            this.dgvCheckupDetails.RowTemplate.Height = 31;
            this.dgvCheckupDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckupDetails.Size = new System.Drawing.Size(1228, 1079);
            this.dgvCheckupDetails.TabIndex = 6;
            this.dgvCheckupDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckupDetails_CellClick);
            this.dgvCheckupDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckupDetails_CellContentClick);
            // 
            // AnimalName
            // 
            this.AnimalName.DataPropertyName = "Animal Name";
            this.AnimalName.HeaderText = "Animal Name";
            this.AnimalName.MinimumWidth = 9;
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.ReadOnly = true;
            this.AnimalName.Width = 175;
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "AnimalID";
            this.AnimalID.HeaderText = "Animal ID";
            this.AnimalID.MinimumWidth = 9;
            this.AnimalID.Name = "AnimalID";
            this.AnimalID.ReadOnly = true;
            this.AnimalID.Width = 175;
            // 
            // Species
            // 
            this.Species.DataPropertyName = "Species";
            this.Species.HeaderText = "Species";
            this.Species.MinimumWidth = 9;
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            this.Species.Width = 175;
            // 
            // DoctorNames
            // 
            this.DoctorNames.DataPropertyName = "DoctorNames";
            this.DoctorNames.HeaderText = "Doctor Name";
            this.DoctorNames.MinimumWidth = 9;
            this.DoctorNames.Name = "DoctorNames";
            this.DoctorNames.ReadOnly = true;
            this.DoctorNames.Width = 175;
            // 
            // CheckupDate
            // 
            this.CheckupDate.DataPropertyName = "Checkup Date";
            this.CheckupDate.HeaderText = "Checkup Date";
            this.CheckupDate.MinimumWidth = 9;
            this.CheckupDate.Name = "CheckupDate";
            this.CheckupDate.ReadOnly = true;
            this.CheckupDate.Width = 175;
            // 
            // HealthCondition
            // 
            this.HealthCondition.DataPropertyName = "Health Condition";
            this.HealthCondition.HeaderText = "Health Condition";
            this.HealthCondition.MinimumWidth = 9;
            this.HealthCondition.Name = "HealthCondition";
            this.HealthCondition.ReadOnly = true;
            this.HealthCondition.Width = 175;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 9;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 175;
            // 
            // Temperature
            // 
            this.Temperature.DataPropertyName = "Temperature";
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.MinimumWidth = 9;
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            this.Temperature.Width = 175;
            // 
            // HeartRate
            // 
            this.HeartRate.DataPropertyName = "Heart Rate";
            this.HeartRate.HeaderText = "Heart Rate";
            this.HeartRate.MinimumWidth = 9;
            this.HeartRate.Name = "HeartRate";
            this.HeartRate.ReadOnly = true;
            this.HeartRate.Width = 175;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 9;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 175;
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.MinimumWidth = 9;
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Visible = false;
            this.DoctorID.Width = 175;
            // 
            // CheckupID
            // 
            this.CheckupID.DataPropertyName = "CheckupID";
            this.CheckupID.HeaderText = "CheckupID";
            this.CheckupID.MinimumWidth = 9;
            this.CheckupID.Name = "CheckupID";
            this.CheckupID.ReadOnly = true;
            this.CheckupID.Visible = false;
            this.CheckupID.Width = 175;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(453, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1228, 150);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Checkup Details Of Animals";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnViewAnimal);
            this.panel1.Controls.Add(this.btnChat);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnVisitor);
            this.panel1.Controls.Add(this.btnBank);
            this.panel1.Controls.Add(this.btnEvent);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnCheckupDetails);
            this.panel1.Controls.Add(this.btnMedicalRecord);
            this.panel1.Controls.Add(this.btnWorkSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 1079);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnSettings.Location = new System.Drawing.Point(10, 863);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(440, 83);
            this.btnSettings.TabIndex = 22;
            this.btnSettings.Text = "⚙️  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnViewAnimal
            // 
            this.btnViewAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAnimal.FlatAppearance.BorderSize = 0;
            this.btnViewAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAnimal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnViewAnimal.Location = new System.Drawing.Point(10, 780);
            this.btnViewAnimal.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewAnimal.Name = "btnViewAnimal";
            this.btnViewAnimal.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnViewAnimal.Size = new System.Drawing.Size(440, 83);
            this.btnViewAnimal.TabIndex = 21;
            this.btnViewAnimal.Text = "🐾  View Animals";
            this.btnViewAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAnimal.UseVisualStyleBackColor = false;
            this.btnViewAnimal.Click += new System.EventHandler(this.btnViewAnimal_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnChat.Location = new System.Drawing.Point(10, 697);
            this.btnChat.Margin = new System.Windows.Forms.Padding(6);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnChat.Size = new System.Drawing.Size(440, 83);
            this.btnChat.TabIndex = 20;
            this.btnChat.Text = "💬  Chat";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnStaff.Location = new System.Drawing.Point(10, 614);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(440, 83);
            this.btnStaff.TabIndex = 19;
            this.btnStaff.Text = "👤  Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.Transparent;
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnVisitor.Location = new System.Drawing.Point(10, 531);
            this.btnVisitor.Margin = new System.Windows.Forms.Padding(6);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(440, 83);
            this.btnVisitor.TabIndex = 18;
            this.btnVisitor.Text = "👥  Visitor";
            this.btnVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.UseVisualStyleBackColor = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Transparent;
            this.btnBank.FlatAppearance.BorderSize = 0;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnBank.Location = new System.Drawing.Point(10, 448);
            this.btnBank.Margin = new System.Windows.Forms.Padding(6);
            this.btnBank.Name = "btnBank";
            this.btnBank.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnBank.Size = new System.Drawing.Size(440, 83);
            this.btnBank.TabIndex = 17;
            this.btnBank.Text = "💳  Bank";
            this.btnBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEvent.Location = new System.Drawing.Point(10, 365);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(6);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(440, 83);
            this.btnEvent.TabIndex = 16;
            this.btnEvent.Text = "🎉  Event";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnAdmin.Location = new System.Drawing.Point(10, 282);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(440, 83);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "⚙️  Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCheckupDetails
            // 
            this.btnCheckupDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCheckupDetails.FlatAppearance.BorderSize = 0;
            this.btnCheckupDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckupDetails.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckupDetails.ForeColor = System.Drawing.Color.White;
            this.btnCheckupDetails.Location = new System.Drawing.Point(10, 199);
            this.btnCheckupDetails.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckupDetails.Name = "btnCheckupDetails";
            this.btnCheckupDetails.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCheckupDetails.Size = new System.Drawing.Size(440, 83);
            this.btnCheckupDetails.TabIndex = 14;
            this.btnCheckupDetails.Text = "🩺  Checkup Details";
            this.btnCheckupDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckupDetails.UseVisualStyleBackColor = false;
            this.btnCheckupDetails.Click += new System.EventHandler(this.btnCheckupDetails_Click);
            // 
            // btnMedicalRecord
            // 
            this.btnMedicalRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicalRecord.FlatAppearance.BorderSize = 0;
            this.btnMedicalRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalRecord.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicalRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnMedicalRecord.Location = new System.Drawing.Point(10, 116);
            this.btnMedicalRecord.Margin = new System.Windows.Forms.Padding(6);
            this.btnMedicalRecord.Name = "btnMedicalRecord";
            this.btnMedicalRecord.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnMedicalRecord.Size = new System.Drawing.Size(440, 83);
            this.btnMedicalRecord.TabIndex = 13;
            this.btnMedicalRecord.Text = "📋  Medical Record";
            this.btnMedicalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalRecord.UseVisualStyleBackColor = false;
            this.btnMedicalRecord.Click += new System.EventHandler(this.btnMedicalRecord_Click);
            // 
            // btnWorkSchedule
            // 
            this.btnWorkSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkSchedule.FlatAppearance.BorderSize = 0;
            this.btnWorkSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkSchedule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWorkSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnWorkSchedule.Location = new System.Drawing.Point(10, 32);
            this.btnWorkSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorkSchedule.Name = "btnWorkSchedule";
            this.btnWorkSchedule.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnWorkSchedule.Size = new System.Drawing.Size(440, 83);
            this.btnWorkSchedule.TabIndex = 12;
            this.btnWorkSchedule.Text = "📅  Work Schedule";
            this.btnWorkSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkSchedule.UseVisualStyleBackColor = false;
            this.btnWorkSchedule.Click += new System.EventHandler(this.btnWorkSchedule_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 144);
            this.panel2.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(442, 142);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1687, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 1079);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.cmbHealthCondition);
            this.panel5.Controls.Add(this.cmbDoctorName);
            this.panel5.Controls.Add(this.cmbAnimal);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtCheckupID);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dtpCheckupDate);
            this.panel5.Controls.Add(this.BtnRefresh);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtNotes);
            this.panel5.Controls.Add(this.txtHeartRate);
            this.panel5.Controls.Add(this.txtTemperature);
            this.panel5.Controls.Add(this.txtWeight);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(692, 1077);
            this.panel5.TabIndex = 4;
            // 
            // cmbHealthCondition
            // 
            this.cmbHealthCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHealthCondition.FormattingEnabled = true;
            this.cmbHealthCondition.Items.AddRange(new object[] {
            "Sick",
            "Healthy"});
            this.cmbHealthCondition.Location = new System.Drawing.Point(276, 424);
            this.cmbHealthCondition.Name = "cmbHealthCondition";
            this.cmbHealthCondition.Size = new System.Drawing.Size(377, 46);
            this.cmbHealthCondition.TabIndex = 57;
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(264, 838);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(407, 46);
            this.cmbDoctorName.TabIndex = 54;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(264, 773);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(407, 46);
            this.cmbAnimal.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 773);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 38);
            this.label10.TabIndex = 52;
            this.label10.Text = "Animal Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 838);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 38);
            this.label9.TabIndex = 51;
            this.label9.Text = "Doctor Name :";
            // 
            // txtCheckupID
            // 
            this.txtCheckupID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckupID.Location = new System.Drawing.Point(276, 683);
            this.txtCheckupID.Multiline = true;
            this.txtCheckupID.Name = "txtCheckupID";
            this.txtCheckupID.Size = new System.Drawing.Size(377, 47);
            this.txtCheckupID.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 698);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 38);
            this.label8.TabIndex = 31;
            this.label8.Text = "Checkup ID :";
            // 
            // dtpCheckupDate
            // 
            this.dtpCheckupDate.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckupDate.Location = new System.Drawing.Point(276, 79);
            this.dtpCheckupDate.Name = "dtpCheckupDate";
            this.dtpCheckupDate.Size = new System.Drawing.Size(363, 33);
            this.dtpCheckupDate.TabIndex = 30;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(443, 1005);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(176, 53);
            this.BtnRefresh.TabIndex = 28;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(233, 1005);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 53);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(23, 1005);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(176, 53);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New ";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 23;
            this.label6.Text = "Notes :";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(276, 504);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(377, 137);
            this.txtNotes.TabIndex = 22;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeartRate.Location = new System.Drawing.Point(276, 315);
            this.txtHeartRate.Multiline = true;
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(377, 47);
            this.txtHeartRate.TabIndex = 20;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(276, 230);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(377, 47);
            this.txtTemperature.TabIndex = 19;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(276, 140);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(377, 47);
            this.txtWeight.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Health Condition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Heart Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Temperature :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Check Up Date :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1687, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 144);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cmbSearch);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(692, 142);
            this.panel6.TabIndex = 4;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Schedule ID",
            "Employee Name",
            "Animal Name"});
            this.cmbSearch.Location = new System.Drawing.Point(540, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(147, 32);
            this.cmbSearch.TabIndex = 45;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 13);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 29);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 32);
            this.label7.TabIndex = 43;
            this.label7.Text = "Search";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(10, 81);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(137, 53);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CheckupAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2384, 1235);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckupAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckupAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckupAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckupDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpCheckupDate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCheckupDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCheckupID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHealthCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckupID;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnViewAnimal;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCheckupDetails;
        private System.Windows.Forms.Button btnMedicalRecord;
        private System.Windows.Forms.Button btnWorkSchedule;
    }
}