namespace ZooManagementSystem
{
    partial class ForgotPass1
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
            this.txtEmailFP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailFP1
            // 
            this.txtEmailFP1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFP1.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailFP1.Location = new System.Drawing.Point(83, 173);
            this.txtEmailFP1.Multiline = true;
            this.txtEmailFP1.Name = "txtEmailFP1";
            this.txtEmailFP1.Size = new System.Drawing.Size(277, 53);
            this.txtEmailFP1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter Email to send OTP";
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOTP.Location = new System.Drawing.Point(165, 278);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(92, 32);
            this.btnSendOTP.TabIndex = 35;
            this.btnSendOTP.Text = "Send OTP";
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // ForgotPass1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(458, 437);
            this.Controls.Add(this.btnSendOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailFP1);
            this.Name = "ForgotPass1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailFP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendOTP;
    }
}