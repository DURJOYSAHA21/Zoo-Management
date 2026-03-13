namespace ZooManagementSystem
{
    partial class ResetPass
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
            this.btnShowCon2 = new System.Windows.Forms.Button();
            this.btnShowPass2 = new System.Windows.Forms.Button();
            this.lblMatch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.txtPassReset = new System.Windows.Forms.TextBox();
            this.txtConPassReset = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowCon2
            // 
            this.btnShowCon2.BackColor = System.Drawing.Color.MistyRose;
            this.btnShowCon2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCon2.Location = new System.Drawing.Point(595, 417);
            this.btnShowCon2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCon2.Name = "btnShowCon2";
            this.btnShowCon2.Size = new System.Drawing.Size(81, 46);
            this.btnShowCon2.TabIndex = 38;
            this.btnShowCon2.Text = "Show";
            this.btnShowCon2.UseVisualStyleBackColor = false;
            this.btnShowCon2.Click += new System.EventHandler(this.btnShowCon2_Click);
            // 
            // btnShowPass2
            // 
            this.btnShowPass2.BackColor = System.Drawing.Color.MistyRose;
            this.btnShowPass2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPass2.Location = new System.Drawing.Point(595, 184);
            this.btnShowPass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowPass2.Name = "btnShowPass2";
            this.btnShowPass2.Size = new System.Drawing.Size(81, 46);
            this.btnShowPass2.TabIndex = 37;
            this.btnShowPass2.Text = "Show";
            this.btnShowPass2.UseVisualStyleBackColor = false;
            this.btnShowPass2.Click += new System.EventHandler(this.btnShowPass2_Click);
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(88, 474);
            this.lblMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(83, 35);
            this.lblMatch.TabIndex = 36;
            this.lblMatch.Text = "label1";
            this.lblMatch.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 45);
            this.label5.TabIndex = 35;
            this.label5.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 45);
            this.label3.TabIndex = 34;
            this.label3.Text = "Confirm Password";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.lblStrength.ForeColor = System.Drawing.Color.Red;
            this.lblStrength.Location = new System.Drawing.Point(82, 236);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(83, 35);
            this.lblStrength.TabIndex = 33;
            this.lblStrength.Text = "label2";
            this.lblStrength.Visible = false;
            // 
            // txtPassReset
            // 
            this.txtPassReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassReset.Location = new System.Drawing.Point(88, 184);
            this.txtPassReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassReset.Multiline = true;
            this.txtPassReset.Name = "txtPassReset";
            this.txtPassReset.PasswordChar = '#';
            this.txtPassReset.Size = new System.Drawing.Size(481, 44);
            this.txtPassReset.TabIndex = 32;
            this.txtPassReset.TextChanged += new System.EventHandler(this.txtPassReset_TextChanged);
            // 
            // txtConPassReset
            // 
            this.txtConPassReset.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtConPassReset.Location = new System.Drawing.Point(88, 417);
            this.txtConPassReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConPassReset.Multiline = true;
            this.txtConPassReset.Name = "txtConPassReset";
            this.txtConPassReset.PasswordChar = '$';
            this.txtConPassReset.Size = new System.Drawing.Size(481, 44);
            this.txtConPassReset.TabIndex = 31;
            this.txtConPassReset.TextChanged += new System.EventHandler(this.txtConPassReset_TextChanged);
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.BurlyWood;
            this.btnResetPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.Location = new System.Drawing.Point(261, 606);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(150, 60);
            this.btnResetPass.TabIndex = 39;
            this.btnResetPass.Text = "Reset";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(216)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(733, 746);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnShowCon2);
            this.Controls.Add(this.btnShowPass2);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.txtPassReset);
            this.Controls.Add(this.txtConPassReset);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.Load += new System.EventHandler(this.ResetPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCon2;
        private System.Windows.Forms.Button btnShowPass2;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.TextBox txtPassReset;
        private System.Windows.Forms.TextBox txtConPassReset;
        private System.Windows.Forms.Button btnResetPass;
    }
}