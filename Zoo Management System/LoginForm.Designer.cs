namespace ZooManagementSystem
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPassLog = new System.Windows.Forms.TextBox();
            this.txtEmailorID = new System.Windows.Forms.TextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.labelDummy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(177)))), ((int)(((byte)(154)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(350, 548);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 70);
            this.btnLogin.TabIndex = 43;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(209, 548);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 70);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPassLog
            // 
            this.txtPassLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassLog.ForeColor = System.Drawing.Color.Gray;
            this.txtPassLog.Location = new System.Drawing.Point(166, 450);
            this.txtPassLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassLog.Multiline = true;
            this.txtPassLog.Name = "txtPassLog";
            this.txtPassLog.PasswordChar = '*';
            this.txtPassLog.Size = new System.Drawing.Size(313, 44);
            this.txtPassLog.TabIndex = 41;
            this.txtPassLog.Text = "Enter Password";
            this.txtPassLog.UseSystemPasswordChar = true;
            this.txtPassLog.Enter += new System.EventHandler(this.txtPassLog_Enter);
            this.txtPassLog.Leave += new System.EventHandler(this.txtPassLog_Leave);
            // 
            // txtEmailorID
            // 
            this.txtEmailorID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailorID.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailorID.Location = new System.Drawing.Point(166, 369);
            this.txtEmailorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailorID.Name = "txtEmailorID";
            this.txtEmailorID.Size = new System.Drawing.Size(313, 40);
            this.txtEmailorID.TabIndex = 40;
            this.txtEmailorID.Text = "Enter Email or ID";
            this.txtEmailorID.Enter += new System.EventHandler(this.txtEmailorID_Enter);
            this.txtEmailorID.Leave += new System.EventHandler(this.txtEmailorID_Leave);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.btnForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.FlatAppearance.BorderSize = 0;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnForgotPass.Location = new System.Drawing.Point(188, 626);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(314, 68);
            this.btnForgotPass.TabIndex = 44;
            this.btnForgotPass.Text = "Forgot_Password?";
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(166, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 53);
            this.label1.TabIndex = 45;
            this.label1.Text = "Zoo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(166, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 53);
            this.label2.TabIndex = 46;
            this.label2.Text = "Management";
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnShowPass.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPass.Location = new System.Drawing.Point(503, 450);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(80, 48);
            this.btnShowPass.TabIndex = 48;
            this.btnShowPass.Text = "Hide";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // labelDummy
            // 
            this.labelDummy.AutoSize = true;
            this.labelDummy.Location = new System.Drawing.Point(535, 27);
            this.labelDummy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDummy.Name = "labelDummy";
            this.labelDummy.Size = new System.Drawing.Size(76, 25);
            this.labelDummy.TabIndex = 47;
            this.labelDummy.Text = "dummy";
            this.labelDummy.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(198)))), ((int)(((byte)(194)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(144, 712);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 68);
            this.button1.TabIndex = 49;
            this.button1.Text = "Don\'t Have an Account?Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ZooManagementSystem.Properties.Resources.v677_ken_26b_animalbadge__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 908);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 908);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.labelDummy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPassLog);
            this.Controls.Add(this.txtEmailorID);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPassLog;
        private System.Windows.Forms.TextBox txtEmailorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Label labelDummy;
        private System.Windows.Forms.Button button1;
    }
}