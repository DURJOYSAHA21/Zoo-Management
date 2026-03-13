namespace ZooManagementSystem
{
    partial class TransactionOTP
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
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranOTP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVerifyOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerifyOTP.Location = new System.Drawing.Point(197, 231);
            this.btnVerifyOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(126, 52);
            this.btnVerifyOTP.TabIndex = 39;
            this.btnVerifyOTP.Text = "Verify";
            this.btnVerifyOTP.UseVisualStyleBackColor = false;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enter OTP :";
            // 
            // txtTranOTP
            // 
            this.txtTranOTP.BackColor = System.Drawing.Color.LightGray;
            this.txtTranOTP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranOTP.Location = new System.Drawing.Point(96, 109);
            this.txtTranOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTranOTP.Multiline = true;
            this.txtTranOTP.Name = "txtTranOTP";
            this.txtTranOTP.Size = new System.Drawing.Size(283, 60);
            this.txtTranOTP.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 64);
            this.button1.TabIndex = 40;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactionOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTranOTP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionOTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifyOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTranOTP;
        private System.Windows.Forms.Button button1;
    }
}