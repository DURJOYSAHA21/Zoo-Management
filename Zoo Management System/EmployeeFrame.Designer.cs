namespace ZooManagementSystem
{
    partial class EmployeeFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAnimals = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnWriteReport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnTaskAssigned = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployeeGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1999, 1247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewAnimals);
            this.panel1.Controls.Add(this.btnChat);
            this.panel1.Controls.Add(this.btnWriteReport);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnViewProfile);
            this.panel1.Controls.Add(this.btnTaskAssigned);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 1091);
            this.panel1.TabIndex = 0;
            // 
            // btnViewAnimals
            // 
            this.btnViewAnimals.Location = new System.Drawing.Point(60, 464);
            this.btnViewAnimals.Name = "btnViewAnimals";
            this.btnViewAnimals.Size = new System.Drawing.Size(167, 58);
            this.btnViewAnimals.TabIndex = 5;
            this.btnViewAnimals.Text = "View Animals";
            this.btnViewAnimals.UseVisualStyleBackColor = true;
            this.btnViewAnimals.Click += new System.EventHandler(this.btnViewAnimals_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(60, 352);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(167, 58);
            this.btnChat.TabIndex = 4;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnWriteReport
            // 
            this.btnWriteReport.Location = new System.Drawing.Point(60, 241);
            this.btnWriteReport.Name = "btnWriteReport";
            this.btnWriteReport.Size = new System.Drawing.Size(167, 58);
            this.btnWriteReport.TabIndex = 3;
            this.btnWriteReport.Text = "Write Report";
            this.btnWriteReport.UseVisualStyleBackColor = true;
            this.btnWriteReport.Click += new System.EventHandler(this.btnWriteReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(60, 706);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 58);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(60, 131);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(167, 58);
            this.btnViewProfile.TabIndex = 1;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnTaskAssigned
            // 
            this.btnTaskAssigned.Location = new System.Drawing.Point(60, 28);
            this.btnTaskAssigned.Name = "btnTaskAssigned";
            this.btnTaskAssigned.Size = new System.Drawing.Size(167, 56);
            this.btnTaskAssigned.TabIndex = 0;
            this.btnTaskAssigned.Text = "Task Assigned";
            this.btnTaskAssigned.UseVisualStyleBackColor = true;
            this.btnTaskAssigned.Click += new System.EventHandler(this.btnTaskAssigned_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1693, 150);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvEmployeeGrid, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1693, 1091);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 58);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployeeGrid
            // 
            this.dgvEmployeeGrid.AllowUserToAddRows = false;
            this.dgvEmployeeGrid.AllowUserToDeleteRows = false;
            this.dgvEmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeGrid.Location = new System.Drawing.Point(3, 103);
            this.dgvEmployeeGrid.Name = "dgvEmployeeGrid";
            this.dgvEmployeeGrid.ReadOnly = true;
            this.dgvEmployeeGrid.RowHeadersWidth = 72;
            this.dgvEmployeeGrid.Size = new System.Drawing.Size(1687, 985);
            this.dgvEmployeeGrid.TabIndex = 2;
            this.dgvEmployeeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeGrid_CellClick);
            // 
            // EmployeeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 1247);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeFrame";
            this.Text = "EmployeeFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeFrame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmployeeGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnTaskAssigned;
        private System.Windows.Forms.Button btnWriteReport;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnViewAnimals;
        private System.Windows.Forms.Button btnAdd;
    }
}