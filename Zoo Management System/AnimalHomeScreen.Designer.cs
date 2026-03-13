namespace ZooManagementSystem
{
    partial class AnimalHomeScreen
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
            this.loadingIndicator = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingIndicator.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loadingIndicator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadingIndicator.ForeColor = System.Drawing.Color.White;
            this.loadingIndicator.Location = new System.Drawing.Point(700, 500);
            this.loadingIndicator.Minimum = 0;
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.ProgressColor = System.Drawing.Color.SteelBlue;
            this.loadingIndicator.ProgressColor2 = System.Drawing.Color.LightSteelBlue;
            this.loadingIndicator.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loadingIndicator.Size = new System.Drawing.Size(60, 60);
            this.loadingIndicator.TabIndex = 6;
            this.loadingIndicator.Text = "guna2CircleProgressBar1";
            this.loadingIndicator.Visible = false;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(153, 163);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.flowPanel.Size = new System.Drawing.Size(1149, 829);
            this.flowPanel.TabIndex = 3;
            this.flowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanel_Paint);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTextBox.BorderRadius = 15;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Location = new System.Drawing.Point(153, 113);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search animals...";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(300, 40);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshButton.BorderRadius = 15;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.SteelBlue;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.refreshButton.Location = new System.Drawing.Point(1308, 110);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 40);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::ZooManagementSystem.Properties.Resources.ChatGPT_Image_Jul_4__2025__10_12_52_PM;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.flowPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.refreshButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1455, 1145);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AnimalHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ZooManagementSystem.Properties.Resources.ChatGPT_Image_Jul_4__2025__09_53_54_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 1145);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnimalHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Animals";
            this.Load += new System.EventHandler(this.AnimalHomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar loadingIndicator;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}