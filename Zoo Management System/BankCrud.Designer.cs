namespace ZooManagementSystem
{
    partial class BankCrud
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSwift = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBank = new System.Windows.Forms.DataGridView();
            this.BankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SWIFTCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.77559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.22441F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.713062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.28694F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtBankId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.btnDlt);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtSwift);
            this.panel3.Controls.Add(this.txtBankName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(735, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 681);
            this.panel3.TabIndex = 1;
            // 
            // txtBankId
            // 
            this.txtBankId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBankId.Location = new System.Drawing.Point(34, 87);
            this.txtBankId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.ReadOnly = true;
            this.txtBankId.Size = new System.Drawing.Size(333, 29);
            this.txtBankId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bank ID :";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Location = new System.Drawing.Point(221, 462);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(126, 46);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "✏️Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDlt.Location = new System.Drawing.Point(34, 558);
            this.btnDlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(126, 46);
            this.btnDlt.TabIndex = 6;
            this.btnDlt.Text = "🗑️Delete";
            this.btnDlt.UseVisualStyleBackColor = false;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.Location = new System.Drawing.Point(221, 558);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔃Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(34, 462);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSwift
            // 
            this.txtSwift.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSwift.Location = new System.Drawing.Point(34, 346);
            this.txtSwift.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwift.Name = "txtSwift";
            this.txtSwift.Size = new System.Drawing.Size(333, 29);
            this.txtSwift.TabIndex = 3;
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBankName.Location = new System.Drawing.Point(34, 214);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(333, 29);
            this.txtBankName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Swift Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bank Name :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvBank);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 681);
            this.panel2.TabIndex = 0;
            // 
            // dgvBank
            // 
            this.dgvBank.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvBank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankId,
            this.BankName,
            this.IsActive,
            this.SWIFTCode});
            this.dgvBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBank.GridColor = System.Drawing.Color.Black;
            this.dgvBank.Location = new System.Drawing.Point(0, 0);
            this.dgvBank.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBank.Name = "dgvBank";
            this.dgvBank.ReadOnly = true;
            this.dgvBank.RowHeadersWidth = 51;
            this.dgvBank.RowTemplate.Height = 24;
            this.dgvBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBank.Size = new System.Drawing.Size(721, 679);
            this.dgvBank.TabIndex = 0;
            this.dgvBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBank_CellClick);
            // 
            // BankId
            // 
            this.BankId.DataPropertyName = "BankId";
            this.BankId.HeaderText = "Bank ID";
            this.BankId.MinimumWidth = 6;
            this.BankId.Name = "BankId";
            this.BankId.ReadOnly = true;
            this.BankId.Width = 60;
            // 
            // BankName
            // 
            this.BankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "Bank Name";
            this.BankName.MinimumWidth = 6;
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Width = 70;
            // 
            // SWIFTCode
            // 
            this.SWIFTCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SWIFTCode.DataPropertyName = "SWIFTCode";
            this.SWIFTCode.HeaderText = "SWIFT Code";
            this.SWIFTCode.MinimumWidth = 6;
            this.SWIFTCode.Name = "SWIFTCode";
            this.SWIFTCode.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 104);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "🏦 Payment Methods";
            // 
            // BankCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 804);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BankCrud";
            this.Load += new System.EventHandler(this.BankCrud_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SWIFTCode;
        private System.Windows.Forms.TextBox txtSwift;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.Label label4;
    }
}