namespace ZooManagementSystem
{
    partial class Feedback
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.memberHeadLabel = new System.Windows.Forms.Label();
            this.ShowReviewGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.submitButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.progressExcellent = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressVeryGood = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressAverage = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressPoor = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressTerrible = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExcellentNum = new System.Windows.Forms.Label();
            this.veryGoodNum = new System.Windows.Forms.Label();
            this.averageNum = new System.Windows.Forms.Label();
            this.poorNum = new System.Windows.Forms.Label();
            this.teribbleNum = new System.Windows.Forms.Label();
            this.feedbackTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShowReviewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // memberHeadLabel
            // 
            this.memberHeadLabel.AutoSize = true;
            this.memberHeadLabel.BackColor = System.Drawing.Color.Transparent;
            this.memberHeadLabel.Font = new System.Drawing.Font("Maiandra GD", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberHeadLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.memberHeadLabel.Location = new System.Drawing.Point(16, 76);
            this.memberHeadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberHeadLabel.Name = "memberHeadLabel";
            this.memberHeadLabel.Size = new System.Drawing.Size(510, 62);
            this.memberHeadLabel.TabIndex = 40;
            this.memberHeadLabel.Text = "Feedback && Reviews";
            // 
            // ShowReviewGridView
            // 
            this.ShowReviewGridView.AllowUserToAddRows = false;
            this.ShowReviewGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ShowReviewGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowReviewGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ShowReviewGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowReviewGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShowReviewGridView.ColumnHeadersHeight = 18;
            this.ShowReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowReviewGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Message,
            this.Rating,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowReviewGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShowReviewGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowReviewGridView.Location = new System.Drawing.Point(619, 170);
            this.ShowReviewGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowReviewGridView.Name = "ShowReviewGridView";
            this.ShowReviewGridView.ReadOnly = true;
            this.ShowReviewGridView.RowHeadersVisible = false;
            this.ShowReviewGridView.RowHeadersWidth = 51;
            this.ShowReviewGridView.RowTemplate.Height = 24;
            this.ShowReviewGridView.Size = new System.Drawing.Size(782, 632);
            this.ShowReviewGridView.TabIndex = 43;
            this.ShowReviewGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowReviewGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShowReviewGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShowReviewGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShowReviewGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShowReviewGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShowReviewGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowReviewGridView.ThemeStyle.HeaderStyle.Height = 18;
            this.ShowReviewGridView.ThemeStyle.ReadOnly = true;
            this.ShowReviewGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowReviewGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowReviewGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReviewGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowReviewGridView.ThemeStyle.RowsStyle.Height = 24;
            this.ShowReviewGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowReviewGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "SenderName";
            this.FullName.FillWeight = 97.68271F;
            this.FullName.HeaderText = "Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.FillWeight = 97.68271F;
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 106.9519F;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 50;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "SubmissionDate";
            this.Date.FillWeight = 97.68271F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 90;
            // 
            // pnLabel
            // 
            this.pnLabel.AutoSize = true;
            this.pnLabel.BackColor = System.Drawing.Color.Transparent;
            this.pnLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLabel.ForeColor = System.Drawing.Color.Black;
            this.pnLabel.Location = new System.Drawing.Point(1419, 170);
            this.pnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnLabel.Name = "pnLabel";
            this.pnLabel.Size = new System.Drawing.Size(218, 34);
            this.pnLabel.TabIndex = 54;
            this.pnLabel.Text = "Write a Review";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderRadius = 5;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomIconSize = 11F;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1814, 3);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(62, 57);
            this.guna2ControlBox3.TabIndex = 56;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.CustomIconSize = 11F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1884, 3);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(62, 57);
            this.guna2ControlBox2.TabIndex = 55;
            // 
            // submitButton
            // 
            this.submitButton.Animated = true;
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.submitButton.BorderRadius = 9;
            this.submitButton.BorderThickness = 1;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.submitButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.HoverState.FillColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(1719, 554);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(214, 54);
            this.submitButton.TabIndex = 58;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.AutoScroll = true;
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BorderColor = System.Drawing.Color.Black;
            this.searchTextBox.BorderRadius = 5;
            this.searchTextBox.BorderThickness = 2;
            this.searchTextBox.CausesValidation = false;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.Green;
            this.searchTextBox.Location = new System.Drawing.Point(718, 106);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(506, 52);
            this.searchTextBox.TabIndex = 59;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.BorderRadius = 9;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1232, 106);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(169, 54);
            this.guna2Button2.TabIndex = 60;
            this.guna2Button2.Text = "Search";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.ForestGreen;
            this.guna2RatingStar1.Location = new System.Drawing.Point(173, 348);
            this.guna2RatingStar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Gold;
            this.guna2RatingStar1.Size = new System.Drawing.Size(283, 40);
            this.guna2RatingStar1.TabIndex = 61;
            // 
            // progressExcellent
            // 
            this.progressExcellent.AutoRoundedCorners = true;
            this.progressExcellent.BorderRadius = 9;
            this.progressExcellent.Location = new System.Drawing.Point(194, 434);
            this.progressExcellent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressExcellent.Name = "progressExcellent";
            this.progressExcellent.ProgressColor = System.Drawing.Color.Green;
            this.progressExcellent.ProgressColor2 = System.Drawing.Color.Black;
            this.progressExcellent.Size = new System.Drawing.Size(330, 21);
            this.progressExcellent.TabIndex = 62;
            this.progressExcellent.Text = "guna2ProgressBar1";
            this.progressExcellent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressExcellent.Value = 50;
            // 
            // progressVeryGood
            // 
            this.progressVeryGood.AutoRoundedCorners = true;
            this.progressVeryGood.BorderRadius = 9;
            this.progressVeryGood.Location = new System.Drawing.Point(194, 484);
            this.progressVeryGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressVeryGood.Name = "progressVeryGood";
            this.progressVeryGood.ProgressColor = System.Drawing.Color.Green;
            this.progressVeryGood.ProgressColor2 = System.Drawing.Color.Black;
            this.progressVeryGood.Size = new System.Drawing.Size(330, 21);
            this.progressVeryGood.TabIndex = 63;
            this.progressVeryGood.Text = "guna2ProgressBar2";
            this.progressVeryGood.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressVeryGood.Value = 50;
            // 
            // progressAverage
            // 
            this.progressAverage.AutoRoundedCorners = true;
            this.progressAverage.BorderRadius = 9;
            this.progressAverage.Location = new System.Drawing.Point(194, 536);
            this.progressAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressAverage.Name = "progressAverage";
            this.progressAverage.ProgressColor = System.Drawing.Color.Green;
            this.progressAverage.ProgressColor2 = System.Drawing.Color.Black;
            this.progressAverage.Size = new System.Drawing.Size(330, 21);
            this.progressAverage.TabIndex = 64;
            this.progressAverage.Text = "guna2ProgressBar3";
            this.progressAverage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressAverage.Value = 50;
            // 
            // progressPoor
            // 
            this.progressPoor.AutoRoundedCorners = true;
            this.progressPoor.BorderRadius = 9;
            this.progressPoor.Location = new System.Drawing.Point(194, 586);
            this.progressPoor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressPoor.Name = "progressPoor";
            this.progressPoor.ProgressColor = System.Drawing.Color.Green;
            this.progressPoor.ProgressColor2 = System.Drawing.Color.Black;
            this.progressPoor.Size = new System.Drawing.Size(330, 21);
            this.progressPoor.TabIndex = 65;
            this.progressPoor.Text = "guna2ProgressBar4";
            this.progressPoor.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressPoor.Value = 50;
            // 
            // progressTerrible
            // 
            this.progressTerrible.AutoRoundedCorners = true;
            this.progressTerrible.BorderRadius = 9;
            this.progressTerrible.Location = new System.Drawing.Point(194, 638);
            this.progressTerrible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressTerrible.Name = "progressTerrible";
            this.progressTerrible.ProgressColor = System.Drawing.Color.Green;
            this.progressTerrible.ProgressColor2 = System.Drawing.Color.Black;
            this.progressTerrible.Size = new System.Drawing.Size(330, 21);
            this.progressTerrible.TabIndex = 66;
            this.progressTerrible.Text = "guna2ProgressBar5";
            this.progressTerrible.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressTerrible.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Excellent ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 476);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Very good";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 578);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Poor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 628);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Terrible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(32, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 34);
            this.label6.TabIndex = 72;
            this.label6.Text = "Rate your experience ";
            // 
            // ExcellentNum
            // 
            this.ExcellentNum.AutoSize = true;
            this.ExcellentNum.BackColor = System.Drawing.Color.Transparent;
            this.ExcellentNum.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcellentNum.ForeColor = System.Drawing.Color.Black;
            this.ExcellentNum.Location = new System.Drawing.Point(536, 424);
            this.ExcellentNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExcellentNum.Name = "ExcellentNum";
            this.ExcellentNum.Size = new System.Drawing.Size(27, 29);
            this.ExcellentNum.TabIndex = 73;
            this.ExcellentNum.Text = "0";
            // 
            // veryGoodNum
            // 
            this.veryGoodNum.AutoSize = true;
            this.veryGoodNum.BackColor = System.Drawing.Color.Transparent;
            this.veryGoodNum.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veryGoodNum.ForeColor = System.Drawing.Color.Black;
            this.veryGoodNum.Location = new System.Drawing.Point(536, 476);
            this.veryGoodNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.veryGoodNum.Name = "veryGoodNum";
            this.veryGoodNum.Size = new System.Drawing.Size(27, 29);
            this.veryGoodNum.TabIndex = 74;
            this.veryGoodNum.Text = "0";
            // 
            // averageNum
            // 
            this.averageNum.AutoSize = true;
            this.averageNum.BackColor = System.Drawing.Color.Transparent;
            this.averageNum.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageNum.ForeColor = System.Drawing.Color.Black;
            this.averageNum.Location = new System.Drawing.Point(536, 526);
            this.averageNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageNum.Name = "averageNum";
            this.averageNum.Size = new System.Drawing.Size(27, 29);
            this.averageNum.TabIndex = 75;
            this.averageNum.Text = "0";
            // 
            // poorNum
            // 
            this.poorNum.AutoSize = true;
            this.poorNum.BackColor = System.Drawing.Color.Transparent;
            this.poorNum.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poorNum.ForeColor = System.Drawing.Color.Black;
            this.poorNum.Location = new System.Drawing.Point(536, 578);
            this.poorNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poorNum.Name = "poorNum";
            this.poorNum.Size = new System.Drawing.Size(27, 29);
            this.poorNum.TabIndex = 76;
            this.poorNum.Text = "0";
            this.poorNum.Click += new System.EventHandler(this.label10_Click);
            // 
            // teribbleNum
            // 
            this.teribbleNum.AutoSize = true;
            this.teribbleNum.BackColor = System.Drawing.Color.Transparent;
            this.teribbleNum.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teribbleNum.ForeColor = System.Drawing.Color.Black;
            this.teribbleNum.Location = new System.Drawing.Point(536, 628);
            this.teribbleNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teribbleNum.Name = "teribbleNum";
            this.teribbleNum.Size = new System.Drawing.Size(27, 29);
            this.teribbleNum.TabIndex = 77;
            this.teribbleNum.Text = "0";
            // 
            // feedbackTextBox1
            // 
            this.feedbackTextBox1.Animated = true;
            this.feedbackTextBox1.AutoScroll = true;
            this.feedbackTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.feedbackTextBox1.BorderColor = System.Drawing.Color.Black;
            this.feedbackTextBox1.BorderRadius = 2;
            this.feedbackTextBox1.CausesValidation = false;
            this.feedbackTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feedbackTextBox1.DefaultText = "";
            this.feedbackTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.feedbackTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.feedbackTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackTextBox1.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold);
            this.feedbackTextBox1.ForeColor = System.Drawing.Color.Black;
            this.feedbackTextBox1.HoverState.BorderColor = System.Drawing.Color.Green;
            this.feedbackTextBox1.Location = new System.Drawing.Point(1409, 212);
            this.feedbackTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.feedbackTextBox1.Multiline = true;
            this.feedbackTextBox1.Name = "feedbackTextBox1";
            this.feedbackTextBox1.PlaceholderText = "";
            this.feedbackTextBox1.SelectedText = "";
            this.feedbackTextBox1.Size = new System.Drawing.Size(524, 300);
            this.feedbackTextBox1.TabIndex = 78;
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(12, 6);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(63, 66);
            this.guna2CircleButton1.TabIndex = 57;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1950, 830);
            this.Controls.Add(this.feedbackTextBox1);
            this.Controls.Add(this.teribbleNum);
            this.Controls.Add(this.poorNum);
            this.Controls.Add(this.averageNum);
            this.Controls.Add(this.veryGoodNum);
            this.Controls.Add(this.ExcellentNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressTerrible);
            this.Controls.Add(this.progressPoor);
            this.Controls.Add(this.progressAverage);
            this.Controls.Add(this.progressVeryGood);
            this.Controls.Add(this.progressExcellent);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.pnLabel);
            this.Controls.Add(this.ShowReviewGridView);
            this.Controls.Add(this.memberHeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1950, 830);
            this.MinimumSize = new System.Drawing.Size(1950, 830);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowReviewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label memberHeadLabel;
        private Guna.UI2.WinForms.Guna2DataGridView ShowReviewGridView;
        private System.Windows.Forms.Label pnLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button submitButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressExcellent;
        private Guna.UI2.WinForms.Guna2ProgressBar progressTerrible;
        private Guna.UI2.WinForms.Guna2ProgressBar progressPoor;
        private Guna.UI2.WinForms.Guna2ProgressBar progressAverage;
        private Guna.UI2.WinForms.Guna2ProgressBar progressVeryGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label poorNum;
        private System.Windows.Forms.Label averageNum;
        private System.Windows.Forms.Label veryGoodNum;
        private System.Windows.Forms.Label ExcellentNum;
        private System.Windows.Forms.Label teribbleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Guna.UI2.WinForms.Guna2TextBox feedbackTextBox1;
    }
}