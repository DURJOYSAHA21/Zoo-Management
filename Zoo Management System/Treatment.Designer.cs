namespace ZooManagementSystem
{
    partial class Treatment
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
            this.lblAllMedicalRecord = new System.Windows.Forms.Label();
            this.dgvAllMedicalRecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnYourRecord = new System.Windows.Forms.Button();
            this.btnAllRecord = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dtpNextVisitDate = new System.Windows.Forms.DateTimePicker();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.dtpTreatmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblNextVisitDate = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblTreatmentDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseAnimal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMedicalRecord)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel1.Controls.Add(this.lblAllMedicalRecord, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAllMedicalRecord, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.49481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.50519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1941, 1207);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblAllMedicalRecord
            // 
            this.lblAllMedicalRecord.AutoSize = true;
            this.lblAllMedicalRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllMedicalRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllMedicalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllMedicalRecord.Location = new System.Drawing.Point(303, 0);
            this.lblAllMedicalRecord.Name = "lblAllMedicalRecord";
            this.lblAllMedicalRecord.Size = new System.Drawing.Size(935, 162);
            this.lblAllMedicalRecord.TabIndex = 0;
            this.lblAllMedicalRecord.Text = "All Medical Record";
            this.lblAllMedicalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllMedicalRecord
            // 
            this.dgvAllMedicalRecord.AllowUserToAddRows = false;
            this.dgvAllMedicalRecord.AllowUserToDeleteRows = false;
            this.dgvAllMedicalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMedicalRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllMedicalRecord.Location = new System.Drawing.Point(303, 165);
            this.dgvAllMedicalRecord.Name = "dgvAllMedicalRecord";
            this.dgvAllMedicalRecord.ReadOnly = true;
            this.dgvAllMedicalRecord.RowHeadersWidth = 72;
            this.dgvAllMedicalRecord.RowTemplate.Height = 31;
            this.dgvAllMedicalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllMedicalRecord.Size = new System.Drawing.Size(935, 1039);
            this.dgvAllMedicalRecord.TabIndex = 0;
            this.dgvAllMedicalRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllMedicalRecord_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 156);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnYourRecord);
            this.panel2.Controls.Add(this.btnAllRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 1039);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "d";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnYourRecord
            // 
            this.btnYourRecord.Location = new System.Drawing.Point(49, 193);
            this.btnYourRecord.Name = "btnYourRecord";
            this.btnYourRecord.Size = new System.Drawing.Size(176, 54);
            this.btnYourRecord.TabIndex = 2;
            this.btnYourRecord.Text = "Your\'s Record";
            this.btnYourRecord.UseVisualStyleBackColor = true;
            this.btnYourRecord.Click += new System.EventHandler(this.btnYourRecord_Click);
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.Location = new System.Drawing.Point(49, 100);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(176, 53);
            this.btnAllRecord.TabIndex = 0;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseVisualStyleBackColor = true;
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbAnimal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtRecordID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnDeleteRecord);
            this.panel4.Controls.Add(this.BtnRefresh);
            this.panel4.Controls.Add(this.btnNewRecord);
            this.panel4.Controls.Add(this.txtNotes);
            this.panel4.Controls.Add(this.txtStatus);
            this.panel4.Controls.Add(this.dtpNextVisitDate);
            this.panel4.Controls.Add(this.txtMedicine);
            this.panel4.Controls.Add(this.txtTreatment);
            this.panel4.Controls.Add(this.dtpTreatmentDate);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Controls.Add(this.lblNotes);
            this.panel4.Controls.Add(this.lblNextVisitDate);
            this.panel4.Controls.Add(this.lblMedicine);
            this.panel4.Controls.Add(this.lblTreatment);
            this.panel4.Controls.Add(this.lblTreatmentDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1244, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 1039);
            this.panel4.TabIndex = 4;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(252, 804);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(406, 32);
            this.cmbAnimal.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 804);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Animal :";
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(252, 708);
            this.txtRecordID.Multiline = true;
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(406, 50);
            this.txtRecordID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 708);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Record ID ;";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(252, 976);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(176, 53);
            this.btnDeleteRecord.TabIndex = 24;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(482, 976);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(176, 53);
            this.BtnRefresh.TabIndex = 25;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(15, 976);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(176, 53);
            this.btnNewRecord.TabIndex = 4;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(252, 437);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(406, 124);
            this.txtNotes.TabIndex = 23;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(252, 616);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(406, 50);
            this.txtStatus.TabIndex = 22;
            // 
            // dtpNextVisitDate
            // 
            this.dtpNextVisitDate.Location = new System.Drawing.Point(252, 374);
            this.dtpNextVisitDate.Name = "dtpNextVisitDate";
            this.dtpNextVisitDate.Size = new System.Drawing.Size(346, 29);
            this.dtpNextVisitDate.TabIndex = 21;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(252, 207);
            this.txtMedicine.Multiline = true;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(406, 124);
            this.txtMedicine.TabIndex = 20;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(252, 115);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(406, 50);
            this.txtTreatment.TabIndex = 19;
            // 
            // dtpTreatmentDate
            // 
            this.dtpTreatmentDate.Location = new System.Drawing.Point(252, 26);
            this.dtpTreatmentDate.Name = "dtpTreatmentDate";
            this.dtpTreatmentDate.Size = new System.Drawing.Size(346, 29);
            this.dtpTreatmentDate.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(118, 616);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 32);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status :";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(125, 475);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(103, 32);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Notes :";
            // 
            // lblNextVisitDate
            // 
            this.lblNextVisitDate.AutoSize = true;
            this.lblNextVisitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextVisitDate.Location = new System.Drawing.Point(12, 371);
            this.lblNextVisitDate.Name = "lblNextVisitDate";
            this.lblNextVisitDate.Size = new System.Drawing.Size(216, 32);
            this.lblNextVisitDate.TabIndex = 15;
            this.lblNextVisitDate.Text = "Next Visit Date :";
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(84, 207);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(144, 32);
            this.lblMedicine.TabIndex = 14;
            this.lblMedicine.Text = "Medicine :";
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(70, 115);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(158, 32);
            this.lblTreatment.TabIndex = 13;
            this.lblTreatment.Text = "Treatment :";
            // 
            // lblTreatmentDate
            // 
            this.lblTreatmentDate.AutoSize = true;
            this.lblTreatmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentDate.Location = new System.Drawing.Point(3, 23);
            this.lblTreatmentDate.Name = "lblTreatmentDate";
            this.lblTreatmentDate.Size = new System.Drawing.Size(225, 32);
            this.lblTreatmentDate.TabIndex = 12;
            this.lblTreatmentDate.Text = "Treatment Date :";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmbSearch);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnChooseAnimal);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1244, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(694, 156);
            this.panel5.TabIndex = 5;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Record ID",
            "Animal Name"});
            this.cmbSearch.Location = new System.Drawing.Point(538, 7);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(147, 32);
            this.cmbSearch.TabIndex = 30;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 10);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 29);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Search";
            // 
            // btnChooseAnimal
            // 
            this.btnChooseAnimal.Location = new System.Drawing.Point(515, 100);
            this.btnChooseAnimal.Name = "btnChooseAnimal";
            this.btnChooseAnimal.Size = new System.Drawing.Size(176, 53);
            this.btnChooseAnimal.TabIndex = 27;
            this.btnChooseAnimal.Text = "Choose Animal";
            this.btnChooseAnimal.UseVisualStyleBackColor = true;
            this.btnChooseAnimal.Click += new System.EventHandler(this.btnChooseAnimal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 53);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1941, 1207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Treatment";
            this.Text = "Treatment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Treatment_FormClosing);
            this.Load += new System.EventHandler(this.Treatment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMedicalRecord)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAllMedicalRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAllMedicalRecord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnYourRecord;
        private System.Windows.Forms.Button btnAllRecord;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dtpNextVisitDate;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.DateTimePicker dtpTreatmentDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblNextVisitDate;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblTreatmentDate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChooseAnimal;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
    }
}