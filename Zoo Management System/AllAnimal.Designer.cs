namespace ZooManagementSystem
{
    partial class AllAnimal
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
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.Name,
            this.Species,
            this.Gender});
            this.dgvAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimals.Location = new System.Drawing.Point(0, 0);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersWidth = 72;
            this.dgvAnimals.RowTemplate.Height = 31;
            this.dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimals.Size = new System.Drawing.Size(857, 602);
            this.dgvAnimals.TabIndex = 0;
            this.dgvAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimals_CellContentClick);
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "AnimalID";
            this.AnimalID.HeaderText = "AnimalID";
            this.AnimalID.MinimumWidth = 9;
            this.AnimalID.Name = "AnimalID";
            this.AnimalID.ReadOnly = true;
            this.AnimalID.Width = 175;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 9;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Species
            // 
            this.Species.DataPropertyName = "Species";
            this.Species.HeaderText = "Species";
            this.Species.MinimumWidth = 9;
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            this.Species.Width = 175;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 9;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 175;
            // 
            // AllAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 602);
            this.Controls.Add(this.dgvAnimals);
            //this.Name = "AllAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllAnimal_FormClosing);
            this.Load += new System.EventHandler(this.AllAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    }
}