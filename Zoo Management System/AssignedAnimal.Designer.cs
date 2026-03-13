namespace ZooManagementSystem
{
    partial class AssignedAnimal
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
            this.dgvAssignedAnimal = new System.Windows.Forms.DataGridView();
            this.btnProccedCheckUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAssignedAnimal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProccedCheckUp, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1398, 955);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1392, 143);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAssignedAnimal
            // 
            this.dgvAssignedAnimal.AllowUserToAddRows = false;
            this.dgvAssignedAnimal.AllowUserToDeleteRows = false;
            this.dgvAssignedAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedAnimal.Location = new System.Drawing.Point(3, 146);
            this.dgvAssignedAnimal.Name = "dgvAssignedAnimal";
            this.dgvAssignedAnimal.ReadOnly = true;
            this.dgvAssignedAnimal.RowHeadersWidth = 72;
            this.dgvAssignedAnimal.RowTemplate.Height = 31;
            this.dgvAssignedAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedAnimal.ShowRowErrors = false;
            this.dgvAssignedAnimal.Size = new System.Drawing.Size(1392, 710);
            this.dgvAssignedAnimal.TabIndex = 1;
            // 
            // btnProccedCheckUp
            // 
            this.btnProccedCheckUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProccedCheckUp.Location = new System.Drawing.Point(3, 862);
            this.btnProccedCheckUp.Name = "btnProccedCheckUp";
            this.btnProccedCheckUp.Size = new System.Drawing.Size(1392, 90);
            this.btnProccedCheckUp.TabIndex = 2;
            this.btnProccedCheckUp.Text = "Procced To CheckUp";
            this.btnProccedCheckUp.UseVisualStyleBackColor = true;
            this.btnProccedCheckUp.Click += new System.EventHandler(this.btnProccedCheckUp_Click);
            // 
            // AssignedAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 955);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssignedAnimal";
            this.Text = "AssignedAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignedAnimal_FormClosing);
            this.Load += new System.EventHandler(this.AssignedAnimal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAssignedAnimal;
        private System.Windows.Forms.Button btnProccedCheckUp;
    }
}