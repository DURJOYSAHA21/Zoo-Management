namespace ZooManagementSystem
{
    partial class WorkShedule
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAssignAnimal = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblSheduleID = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvWorkSchedule = new System.Windows.Forms.DataGridView();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvWorkSchedule, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2113, 1209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(453, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(957, 150);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Work Schedule of All Employees";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 144);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(442, 142);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnViewAnimal);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Controls.Add(this.btnStaff);
            this.panel2.Controls.Add(this.btnVisitor);
            this.panel2.Controls.Add(this.btnBank);
            this.panel2.Controls.Add(this.btnEvent);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnCheckupDetails);
            this.panel2.Controls.Add(this.btnMedicalRecord);
            this.panel2.Controls.Add(this.btnWorkSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 1053);
            this.panel2.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnSettings.Location = new System.Drawing.Point(1, 899);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(440, 83);
            this.btnSettings.TabIndex = 55;
            this.btnSettings.Text = "⚙️  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnViewAnimal
            // 
            this.btnViewAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAnimal.FlatAppearance.BorderSize = 0;
            this.btnViewAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAnimal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnViewAnimal.Location = new System.Drawing.Point(1, 816);
            this.btnViewAnimal.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewAnimal.Name = "btnViewAnimal";
            this.btnViewAnimal.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnViewAnimal.Size = new System.Drawing.Size(440, 83);
            this.btnViewAnimal.TabIndex = 54;
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
            this.btnChat.Location = new System.Drawing.Point(1, 733);
            this.btnChat.Margin = new System.Windows.Forms.Padding(6);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnChat.Size = new System.Drawing.Size(440, 83);
            this.btnChat.TabIndex = 53;
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
            this.btnStaff.Location = new System.Drawing.Point(1, 650);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(440, 83);
            this.btnStaff.TabIndex = 52;
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
            this.btnVisitor.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnVisitor.Location = new System.Drawing.Point(1, 567);
            this.btnVisitor.Margin = new System.Windows.Forms.Padding(6);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(440, 83);
            this.btnVisitor.TabIndex = 51;
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
            this.btnBank.Location = new System.Drawing.Point(1, 484);
            this.btnBank.Margin = new System.Windows.Forms.Padding(6);
            this.btnBank.Name = "btnBank";
            this.btnBank.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnBank.Size = new System.Drawing.Size(440, 83);
            this.btnBank.TabIndex = 50;
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
            this.btnEvent.Location = new System.Drawing.Point(1, 401);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(6);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(440, 83);
            this.btnEvent.TabIndex = 49;
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
            this.btnAdmin.Location = new System.Drawing.Point(1, 318);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(440, 83);
            this.btnAdmin.TabIndex = 48;
            this.btnAdmin.Text = "⚙️  Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnCheckupDetails
            // 
            this.btnCheckupDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckupDetails.FlatAppearance.BorderSize = 0;
            this.btnCheckupDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckupDetails.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckupDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCheckupDetails.Location = new System.Drawing.Point(1, 235);
            this.btnCheckupDetails.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckupDetails.Name = "btnCheckupDetails";
            this.btnCheckupDetails.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCheckupDetails.Size = new System.Drawing.Size(440, 83);
            this.btnCheckupDetails.TabIndex = 47;
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
            this.btnMedicalRecord.Location = new System.Drawing.Point(1, 152);
            this.btnMedicalRecord.Margin = new System.Windows.Forms.Padding(6);
            this.btnMedicalRecord.Name = "btnMedicalRecord";
            this.btnMedicalRecord.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnMedicalRecord.Size = new System.Drawing.Size(440, 83);
            this.btnMedicalRecord.TabIndex = 46;
            this.btnMedicalRecord.Text = "📋  Medical Record";
            this.btnMedicalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalRecord.UseVisualStyleBackColor = false;
            this.btnMedicalRecord.Click += new System.EventHandler(this.btnMedicalRecord_Click);
            // 
            // btnWorkSchedule
            // 
            this.btnWorkSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnWorkSchedule.FlatAppearance.BorderSize = 0;
            this.btnWorkSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkSchedule.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkSchedule.ForeColor = System.Drawing.Color.White;
            this.btnWorkSchedule.Location = new System.Drawing.Point(1, 68);
            this.btnWorkSchedule.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorkSchedule.Name = "btnWorkSchedule";
            this.btnWorkSchedule.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnWorkSchedule.Size = new System.Drawing.Size(440, 83);
            this.btnWorkSchedule.TabIndex = 45;
            this.btnWorkSchedule.Text = "📅  Work Schedule";
            this.btnWorkSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkSchedule.UseVisualStyleBackColor = false;
            this.btnWorkSchedule.Click += new System.EventHandler(this.btnWorkSchedule_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1416, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 144);
            this.panel3.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(-1, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 53);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbStatus);
            this.panel4.Controls.Add(this.txtTask);
            this.panel4.Controls.Add(this.dtpWorkDate);
            this.panel4.Controls.Add(this.cmbAssignAnimal);
            this.panel4.Controls.Add(this.cmbEmployee);
            this.panel4.Controls.Add(this.txtScheduleID);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblEmployee);
            this.panel4.Controls.Add(this.lblSheduleID);
            this.panel4.Controls.Add(this.BtnRefresh);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1416, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 1053);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 705);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending ",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(220, 705);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(434, 32);
            this.cmbStatus.TabIndex = 42;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(220, 470);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(434, 176);
            this.txtTask.TabIndex = 41;
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Location = new System.Drawing.Point(220, 268);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(434, 29);
            this.dtpWorkDate.TabIndex = 40;
            // 
            // cmbAssignAnimal
            // 
            this.cmbAssignAnimal.FormattingEnabled = true;
            this.cmbAssignAnimal.Location = new System.Drawing.Point(220, 372);
            this.cmbAssignAnimal.Name = "cmbAssignAnimal";
            this.cmbAssignAnimal.Size = new System.Drawing.Size(434, 32);
            this.cmbAssignAnimal.TabIndex = 39;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(220, 162);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(434, 32);
            this.cmbEmployee.TabIndex = 38;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(220, 69);
            this.txtScheduleID.Multiline = true;
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(434, 48);
            this.txtScheduleID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Task :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Assign Animal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Work Date :";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(58, 162);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(156, 32);
            this.lblEmployee.TabIndex = 33;
            this.lblEmployee.Text = "Employee :";
            // 
            // lblSheduleID
            // 
            this.lblSheduleID.AutoSize = true;
            this.lblSheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheduleID.Location = new System.Drawing.Point(31, 69);
            this.lblSheduleID.Name = "lblSheduleID";
            this.lblSheduleID.Size = new System.Drawing.Size(183, 32);
            this.lblSheduleID.TabIndex = 32;
            this.lblSheduleID.Text = "Schedule ID :";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(489, 901);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(176, 53);
            this.BtnRefresh.TabIndex = 31;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 901);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 53);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(30, 901);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(176, 53);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvWorkSchedule
            // 
            this.dgvWorkSchedule.AllowUserToAddRows = false;
            this.dgvWorkSchedule.AllowUserToDeleteRows = false;
            this.dgvWorkSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleID,
            this.EmployeeName,
            this.WorkDate,
            this.Task,
            this.AnimalID,
            this.AnimalName,
            this.Species,
            this.UpdatedByName,
            this.EmployeeID,
            this.Status});
            this.dgvWorkSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkSchedule.Location = new System.Drawing.Point(453, 153);
            this.dgvWorkSchedule.Name = "dgvWorkSchedule";
            this.dgvWorkSchedule.ReadOnly = true;
            this.dgvWorkSchedule.RowHeadersWidth = 72;
            this.dgvWorkSchedule.RowTemplate.Height = 31;
            this.dgvWorkSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkSchedule.Size = new System.Drawing.Size(957, 1053);
            this.dgvWorkSchedule.TabIndex = 5;
            this.dgvWorkSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkSchedule_CellClick);
            this.dgvWorkSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkSchedule_CellContentClick);
            // 
            // ScheduleID
            // 
            this.ScheduleID.DataPropertyName = "ScheduleID";
            this.ScheduleID.HeaderText = "Schedule ID";
            this.ScheduleID.MinimumWidth = 9;
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.ReadOnly = true;
            this.ScheduleID.Width = 175;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 9;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 175;
            // 
            // WorkDate
            // 
            this.WorkDate.DataPropertyName = "WorkDate";
            this.WorkDate.HeaderText = "WorkDate";
            this.WorkDate.MinimumWidth = 9;
            this.WorkDate.Name = "WorkDate";
            this.WorkDate.ReadOnly = true;
            this.WorkDate.Width = 175;
            // 
            // Task
            // 
            this.Task.DataPropertyName = "Task";
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 9;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            this.Task.Width = 175;
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
            // AnimalName
            // 
            this.AnimalName.DataPropertyName = "AnimalName";
            this.AnimalName.HeaderText = "Animal Name";
            this.AnimalName.MinimumWidth = 9;
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.ReadOnly = true;
            this.AnimalName.Width = 175;
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
            // UpdatedByName
            // 
            this.UpdatedByName.DataPropertyName = "UpdatedByName";
            this.UpdatedByName.HeaderText = "Update By";
            this.UpdatedByName.MinimumWidth = 9;
            this.UpdatedByName.Name = "UpdatedByName";
            this.UpdatedByName.ReadOnly = true;
            this.UpdatedByName.Width = 175;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 9;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            this.EmployeeID.Width = 175;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 9;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 175;
            // 
            // WorkShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2113, 1209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WorkShedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkShedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkShedule_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvWorkSchedule;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSheduleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.ComboBox cmbAssignAnimal;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
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