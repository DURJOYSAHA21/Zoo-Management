namespace ZooManagementSystem
{
    partial class Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBankSelect = new System.Windows.Forms.ComboBox();
            this.grpbxAccInfo = new System.Windows.Forms.GroupBox();
            this.lblHolderName = new System.Windows.Forms.Label();
            this.txtAccEmail = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProceedTran = new System.Windows.Forms.Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.grpbxAccInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(407, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Zoo Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Method :";
            // 
            // cmbBankSelect
            // 
            this.cmbBankSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBankSelect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbBankSelect.Items.AddRange(new object[] {
            "City bank",
            "Brac Bank",
            "Bank Asia"});
            this.cmbBankSelect.Location = new System.Drawing.Point(330, 162);
            this.cmbBankSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBankSelect.Name = "cmbBankSelect";
            this.cmbBankSelect.Size = new System.Drawing.Size(492, 33);
            this.cmbBankSelect.TabIndex = 3;
            this.cmbBankSelect.TabStop = false;
            this.cmbBankSelect.Text = " Please Select a Bank To Pay";
            this.cmbBankSelect.SelectedIndexChanged += new System.EventHandler(this.cmbBankSelect_SelectedIndexChanged);
            // 
            // grpbxAccInfo
            // 
            this.grpbxAccInfo.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpbxAccInfo.Controls.Add(this.lblHolderName);
            this.grpbxAccInfo.Controls.Add(this.txtAccEmail);
            this.grpbxAccInfo.Controls.Add(this.txtAccountNo);
            this.grpbxAccInfo.Controls.Add(this.label4);
            this.grpbxAccInfo.Controls.Add(this.label3);
            this.grpbxAccInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbxAccInfo.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAccInfo.Location = new System.Drawing.Point(45, 261);
            this.grpbxAccInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxAccInfo.Name = "grpbxAccInfo";
            this.grpbxAccInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxAccInfo.Size = new System.Drawing.Size(778, 286);
            this.grpbxAccInfo.TabIndex = 4;
            this.grpbxAccInfo.TabStop = false;
            this.grpbxAccInfo.Text = "Bank Account Info";
            this.grpbxAccInfo.Visible = false;
            // 
            // lblHolderName
            // 
            this.lblHolderName.AutoSize = true;
            this.lblHolderName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHolderName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHolderName.Location = new System.Drawing.Point(126, 122);
            this.lblHolderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolderName.Name = "lblHolderName";
            this.lblHolderName.Size = new System.Drawing.Size(78, 38);
            this.lblHolderName.TabIndex = 4;
            this.lblHolderName.Text = "label";
            this.lblHolderName.Visible = false;
            // 
            // txtAccEmail
            // 
            this.txtAccEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccEmail.Location = new System.Drawing.Point(439, 188);
            this.txtAccEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccEmail.Name = "txtAccEmail";
            this.txtAccEmail.Size = new System.Drawing.Size(311, 36);
            this.txtAccEmail.TabIndex = 3;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(396, 50);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(338, 36);
            this.txtAccountNo.TabIndex = 2;
            this.txtAccountNo.Leave += new System.EventHandler(this.txtAccountNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(126, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account Holder Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(126, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Number :";
            // 
            // btnProceedTran
            // 
            this.btnProceedTran.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnProceedTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedTran.Location = new System.Drawing.Point(358, 582);
            this.btnProceedTran.Margin = new System.Windows.Forms.Padding(4);
            this.btnProceedTran.Name = "btnProceedTran";
            this.btnProceedTran.Size = new System.Drawing.Size(118, 51);
            this.btnProceedTran.TabIndex = 5;
            this.btnProceedTran.Text = "Proceed";
            this.btnProceedTran.UseVisualStyleBackColor = false;
            this.btnProceedTran.Click += new System.EventHandler(this.btnProceedTran_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Gold;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.Location = new System.Drawing.Point(13, 14);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(56, 58);
            this.guna2CircleButton1.TabIndex = 68;
            this.guna2CircleButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(862, 675);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btnProceedTran);
            this.Controls.Add(this.grpbxAccInfo);
            this.Controls.Add(this.cmbBankSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.grpbxAccInfo.ResumeLayout(false);
            this.grpbxAccInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBankSelect;
        private System.Windows.Forms.GroupBox grpbxAccInfo;
        private System.Windows.Forms.TextBox txtAccEmail;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProceedTran;
        private System.Windows.Forms.Label lblHolderName;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}