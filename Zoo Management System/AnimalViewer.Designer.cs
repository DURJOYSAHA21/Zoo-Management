namespace ZooManagementSystem
{
    partial class AnimalViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalViewer));
            this.pictureBoxAnimalPicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelZooID = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelHealthStatus = new System.Windows.Forms.Label();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnimalPicture
            // 
            this.pictureBoxAnimalPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAnimalPicture.Location = new System.Drawing.Point(172, 55);
            this.pictureBoxAnimalPicture.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxAnimalPicture.Name = "pictureBoxAnimalPicture";
            this.pictureBoxAnimalPicture.Size = new System.Drawing.Size(231, 231);
            this.pictureBoxAnimalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimalPicture.TabIndex = 0;
            this.pictureBoxAnimalPicture.TabStop = false;
            this.pictureBoxAnimalPicture.Click += new System.EventHandler(this.pictureBoxAnimalPicture_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(22, 362);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(385, 69);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "AnimalName";
            // 
            // labelZooID
            // 
            this.labelZooID.AutoSize = true;
            this.labelZooID.BackColor = System.Drawing.Color.Transparent;
            this.labelZooID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZooID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelZooID.Location = new System.Drawing.Point(28, 471);
            this.labelZooID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZooID.Name = "labelZooID";
            this.labelZooID.Size = new System.Drawing.Size(169, 33);
            this.labelZooID.TabIndex = 3;
            this.labelZooID.Text = "AnimalZooID";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.BackColor = System.Drawing.Color.Transparent;
            this.labelSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSpecies.Location = new System.Drawing.Point(28, 530);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(181, 33);
            this.labelSpecies.TabIndex = 2;
            this.labelSpecies.Text = "AnimalSpecies";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.BackColor = System.Drawing.Color.Transparent;
            this.labelSName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSName.Location = new System.Drawing.Point(28, 587);
            this.labelSName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(267, 33);
            this.labelSName.TabIndex = 4;
            this.labelSName.Text = "AnimalScientificName";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Transparent;
            this.labelAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAge.Location = new System.Drawing.Point(28, 652);
            this.labelAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(140, 33);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "AnimalAge";
            // 
            // labelHealthStatus
            // 
            this.labelHealthStatus.AutoSize = true;
            this.labelHealthStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHealthStatus.Location = new System.Drawing.Point(28, 779);
            this.labelHealthStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHealthStatus.Name = "labelHealthStatus";
            this.labelHealthStatus.Size = new System.Drawing.Size(238, 33);
            this.labelHealthStatus.TabIndex = 6;
            this.labelHealthStatus.Text = "AnimalHealthStatus";
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.BackColor = System.Drawing.Color.Transparent;
            this.labelArrivalDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelArrivalDate.Location = new System.Drawing.Point(28, 713);
            this.labelArrivalDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(225, 33);
            this.labelArrivalDate.TabIndex = 7;
            this.labelArrivalDate.Text = "AnimalArrivalDate";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.Location = new System.Drawing.Point(3, 5);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(56, 58);
            this.guna2CircleButton1.TabIndex = 68;
            this.guna2CircleButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnimalViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 914);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.labelArrivalDate);
            this.Controls.Add(this.labelHealthStatus);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelZooID);
            this.Controls.Add(this.pictureBoxAnimalPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnimalViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalViewer_FormClosing);
            this.Load += new System.EventHandler(this.AnimalViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnimalPicture;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelZooID;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelHealthStatus;
        private System.Windows.Forms.Label labelArrivalDate;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}