namespace ZooManagementSystem
{
    partial class CheckUpDetails
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseAnimal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCheckupDetails = new System.Windows.Forms.DataGridView();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYourCheckups = new System.Windows.Forms.Button();
            this.btnAllCheckup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbHealthCondition = new System.Windows.Forms.ComboBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckupDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.19048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 705F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCheckupDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2012, 1183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Controls.Add(this.cmbSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnChooseAnimal);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1309, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 171);
            this.panel4.TabIndex = 5;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Checkup ID",
            "Animal Name",
            "Doctor Name"});
            this.cmbSearch.Location = new System.Drawing.Point(543, 16);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(147, 32);
            this.cmbSearch.TabIndex = 33;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(104, 19);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 29);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Search";
            // 
            // btnChooseAnimal
            // 
            this.btnChooseAnimal.Location = new System.Drawing.Point(524, 115);
            this.btnChooseAnimal.Name = "btnChooseAnimal";
            this.btnChooseAnimal.Size = new System.Drawing.Size(176, 53);
            this.btnChooseAnimal.TabIndex = 30;
            this.btnChooseAnimal.Text = "Choose Animal";
            this.btnChooseAnimal.UseVisualStyleBackColor = true;
            this.btnChooseAnimal.Click += new System.EventHandler(this.btnChooseAnimal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 53);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(314, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(989, 177);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Checkup Details Of Animals";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCheckupDetails
            // 
            this.dgvCheckupDetails.AllowUserToAddRows = false;
            this.dgvCheckupDetails.AllowUserToDeleteRows = false;
            this.dgvCheckupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckupDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalName,
            this.AnimalIDs,
            this.Species,
            this.FullName,
            this.CheckupDate,
            this.HealthCondition,
            this.Weight,
            this.Temperature,
            this.HeartRate,
            this.Notes,
            this.DoctorID,
            this.CheckupID});
            this.dgvCheckupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckupDetails.Location = new System.Drawing.Point(314, 180);
            this.dgvCheckupDetails.Name = "dgvCheckupDetails";
            this.dgvCheckupDetails.ReadOnly = true;
            this.dgvCheckupDetails.RowHeadersWidth = 72;
            this.dgvCheckupDetails.RowTemplate.Height = 31;
            this.dgvCheckupDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckupDetails.Size = new System.Drawing.Size(989, 1000);
            this.dgvCheckupDetails.TabIndex = 1;
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
            // AnimalIDs
            // 
            this.AnimalIDs.DataPropertyName = "AnimalID";
            this.AnimalIDs.HeaderText = "Animal ID";
            this.AnimalIDs.MinimumWidth = 9;
            this.AnimalIDs.Name = "AnimalIDs";
            this.AnimalIDs.ReadOnly = true;
            this.AnimalIDs.Width = 175;
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
            // FullName
            // 
            this.FullName.DataPropertyName = "Doctor Name";
            this.FullName.HeaderText = "Doctor Name";
            this.FullName.MinimumWidth = 9;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 175;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnYourCheckups);
            this.panel1.Controls.Add(this.btnAllCheckup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 1000);
            this.panel1.TabIndex = 2;
            // 
            // btnYourCheckups
            // 
            this.btnYourCheckups.Location = new System.Drawing.Point(27, 254);
            this.btnYourCheckups.Name = "btnYourCheckups";
            this.btnYourCheckups.Size = new System.Drawing.Size(228, 57);
            this.btnYourCheckups.TabIndex = 1;
            this.btnYourCheckups.Text = "Your Checkups";
            this.btnYourCheckups.UseVisualStyleBackColor = true;
            this.btnYourCheckups.Click += new System.EventHandler(this.btnYourCheckups_Click);
            // 
            // btnAllCheckup
            // 
            this.btnAllCheckup.Location = new System.Drawing.Point(27, 151);
            this.btnAllCheckup.Name = "btnAllCheckup";
            this.btnAllCheckup.Size = new System.Drawing.Size(228, 57);
            this.btnAllCheckup.TabIndex = 0;
            this.btnAllCheckup.Text = "All Checkups";
            this.btnAllCheckup.UseVisualStyleBackColor = true;
            this.btnAllCheckup.Click += new System.EventHandler(this.btnAllCheckup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.cmbHealthCondition);
            this.panel2.Controls.Add(this.cmbAnimal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtpCheckupDate);
            this.panel2.Controls.Add(this.BtnRefresh);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNotes);
            this.panel2.Controls.Add(this.txtHeartRate);
            this.panel2.Controls.Add(this.txtTemperature);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1309, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 1000);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbHealthCondition
            // 
            this.cmbHealthCondition.FormattingEnabled = true;
            this.cmbHealthCondition.Items.AddRange(new object[] {
            "Sick",
            "Healthy"});
            this.cmbHealthCondition.Location = new System.Drawing.Point(276, 424);
            this.cmbHealthCondition.Name = "cmbHealthCondition";
            this.cmbHealthCondition.Size = new System.Drawing.Size(377, 32);
            this.cmbHealthCondition.TabIndex = 56;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(249, 682);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(407, 32);
            this.cmbAnimal.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 682);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 31);
            this.label10.TabIndex = 54;
            this.label10.Text = "Animal Name :";
            // 
            // dtpCheckupDate
            // 
            this.dtpCheckupDate.Location = new System.Drawing.Point(276, 79);
            this.dtpCheckupDate.Name = "dtpCheckupDate";
            this.dtpCheckupDate.Size = new System.Drawing.Size(363, 29);
            this.dtpCheckupDate.TabIndex = 30;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(486, 826);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(176, 53);
            this.BtnRefresh.TabIndex = 28;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 826);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 53);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(27, 826);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(176, 53);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Notes :";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(276, 504);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(377, 137);
            this.txtNotes.TabIndex = 22;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(276, 315);
            this.txtHeartRate.Multiline = true;
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(377, 47);
            this.txtHeartRate.TabIndex = 20;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(276, 230);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(377, 47);
            this.txtTemperature.TabIndex = 19;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(276, 140);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(377, 47);
            this.txtWeight.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Health Condition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Heart Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Temperature :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Check Up Date :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 171);
            this.panel3.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-5, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(308, 174);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckUpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2012, 1183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckUpDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckUpDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckUpDetails_FormClosing);
            this.Load += new System.EventHandler(this.CheckUpDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckupDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCheckupDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYourCheckups;
        private System.Windows.Forms.Button btnAllCheckup;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChooseAnimal;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpCheckupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalIDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckupID;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHealthCondition;
    }
}