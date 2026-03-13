namespace ZooManagementSystem
{
    partial class OTP
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
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.LightGray;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(38, 130);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOTP.Multiline = true;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(283, 60);
            this.txtOTP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter OTP :";
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVerifyOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerifyOTP.Location = new System.Drawing.Point(221, 255);
            this.btnVerifyOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(126, 52);
            this.btnVerifyOTP.TabIndex = 36;
            this.btnVerifyOTP.Text = "Verify";
            this.btnVerifyOTP.UseVisualStyleBackColor = false;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(579, 387);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOTP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTP";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerifyOTP;
    }
}