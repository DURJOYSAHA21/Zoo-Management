namespace ZooManagementSystem
{
    partial class Report
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
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelDescribe = new System.Windows.Forms.Label();
            this.cmbSelectAnimal = new System.Windows.Forms.ComboBox();
            this.panelLoadSelectedAnimal = new System.Windows.Forms.Panel();
            this.groupBoxAnimalDetails = new System.Windows.Forms.GroupBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtboxSpecies = new System.Windows.Forms.TextBox();
            this.labelScientificName = new System.Windows.Forms.Label();
            this.txtboxSN = new System.Windows.Forms.TextBox();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.txtboxGender = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtboxStatus = new System.Windows.Forms.TextBox();
            this.labelAAge = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelHealthStatus = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.panelWriteReport = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.cmbBreathing = new System.Windows.Forms.ComboBox();
            this.cmbUrination = new System.Windows.Forms.ComboBox();
            this.cmbEyes = new System.Windows.Forms.ComboBox();
            this.cmbHydration = new System.Windows.Forms.ComboBox();
            this.cmbAppetite = new System.Windows.Forms.ComboBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.cmbAppearance = new System.Windows.Forms.ComboBox();
            this.txtboxReportDate = new System.Windows.Forms.TextBox();
            this.labeleyes = new System.Windows.Forms.Label();
            this.labelBreathing = new System.Windows.Forms.Label();
            this.labelUrination = new System.Windows.Forms.Label();
            this.labelAppetite = new System.Windows.Forms.Label();
            this.labelHydrationStatus = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelAppearance = new System.Windows.Forms.Label();
            this.labelReportDate = new System.Windows.Forms.Label();
            this.panelLoadSelectedAnimal.SuspendLayout();
            this.groupBoxAnimalDetails.SuspendLayout();
            this.panelWriteReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.BackColor = System.Drawing.Color.Transparent;
            this.labelStaffName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.Location = new System.Drawing.Point(24, 33);
            this.labelStaffName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(298, 55);
            this.labelStaffName.TabIndex = 1;
            this.labelStaffName.Text = "StaffNameID";
            // 
            // labelDescribe
            // 
            this.labelDescribe.AutoSize = true;
            this.labelDescribe.BackColor = System.Drawing.Color.Transparent;
            this.labelDescribe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescribe.Location = new System.Drawing.Point(28, 107);
            this.labelDescribe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescribe.Name = "labelDescribe";
            this.labelDescribe.Size = new System.Drawing.Size(588, 39);
            this.labelDescribe.TabIndex = 2;
            this.labelDescribe.Text = "Select an Animal To Write Todays Report:";
            // 
            // cmbSelectAnimal
            // 
            this.cmbSelectAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAnimal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectAnimal.FormattingEnabled = true;
            this.cmbSelectAnimal.Location = new System.Drawing.Point(35, 168);
            this.cmbSelectAnimal.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSelectAnimal.Name = "cmbSelectAnimal";
            this.cmbSelectAnimal.Size = new System.Drawing.Size(294, 37);
            this.cmbSelectAnimal.Sorted = true;
            this.cmbSelectAnimal.TabIndex = 1;
            this.cmbSelectAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbSelectAnimal_SelectedIndexChanged);
            // 
            // panelLoadSelectedAnimal
            // 
            this.panelLoadSelectedAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadSelectedAnimal.Controls.Add(this.groupBoxAnimalDetails);
            this.panelLoadSelectedAnimal.Controls.Add(this.btnLoadData);
            this.panelLoadSelectedAnimal.Controls.Add(this.labelStaffName);
            this.panelLoadSelectedAnimal.Controls.Add(this.cmbSelectAnimal);
            this.panelLoadSelectedAnimal.Controls.Add(this.labelDescribe);
            this.panelLoadSelectedAnimal.Location = new System.Drawing.Point(22, 22);
            this.panelLoadSelectedAnimal.Margin = new System.Windows.Forms.Padding(6);
            this.panelLoadSelectedAnimal.Name = "panelLoadSelectedAnimal";
            this.panelLoadSelectedAnimal.Size = new System.Drawing.Size(655, 927);
            this.panelLoadSelectedAnimal.TabIndex = 3;
            // 
            // groupBoxAnimalDetails
            // 
            this.groupBoxAnimalDetails.AutoSize = true;
            this.groupBoxAnimalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxName);
            this.groupBoxAnimalDetails.Controls.Add(this.labelID);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxSpecies);
            this.groupBoxAnimalDetails.Controls.Add(this.labelScientificName);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxSN);
            this.groupBoxAnimalDetails.Controls.Add(this.labelSpecies);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxGender);
            this.groupBoxAnimalDetails.Controls.Add(this.labelName);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxStatus);
            this.groupBoxAnimalDetails.Controls.Add(this.labelAAge);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxDate);
            this.groupBoxAnimalDetails.Controls.Add(this.labelGender);
            this.groupBoxAnimalDetails.Controls.Add(this.textBox3);
            this.groupBoxAnimalDetails.Controls.Add(this.labelHealthStatus);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxAge);
            this.groupBoxAnimalDetails.Controls.Add(this.labelArrivalDate);
            this.groupBoxAnimalDetails.Controls.Add(this.txtboxID);
            this.groupBoxAnimalDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnimalDetails.Location = new System.Drawing.Point(35, 253);
            this.groupBoxAnimalDetails.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalDetails.Name = "groupBoxAnimalDetails";
            this.groupBoxAnimalDetails.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxAnimalDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxAnimalDetails.Size = new System.Drawing.Size(465, 571);
            this.groupBoxAnimalDetails.TabIndex = 4;
            this.groupBoxAnimalDetails.TabStop = false;
            this.groupBoxAnimalDetails.Text = "Animal Details :";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(273, 131);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.ReadOnly = true;
            this.txtboxName.Size = new System.Drawing.Size(180, 40);
            this.txtboxName.TabIndex = 19;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(57, 78);
            this.labelID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(146, 33);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "Animal ID :";
            // 
            // txtboxSpecies
            // 
            this.txtboxSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSpecies.Location = new System.Drawing.Point(273, 190);
            this.txtboxSpecies.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxSpecies.Name = "txtboxSpecies";
            this.txtboxSpecies.ReadOnly = true;
            this.txtboxSpecies.Size = new System.Drawing.Size(180, 40);
            this.txtboxSpecies.TabIndex = 18;
            // 
            // labelScientificName
            // 
            this.labelScientificName.AutoSize = true;
            this.labelScientificName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScientificName.Location = new System.Drawing.Point(57, 253);
            this.labelScientificName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelScientificName.Name = "labelScientificName";
            this.labelScientificName.Size = new System.Drawing.Size(208, 33);
            this.labelScientificName.TabIndex = 5;
            this.labelScientificName.Text = "Scientific Name :";
            // 
            // txtboxSN
            // 
            this.txtboxSN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSN.Location = new System.Drawing.Point(273, 249);
            this.txtboxSN.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxSN.Name = "txtboxSN";
            this.txtboxSN.ReadOnly = true;
            this.txtboxSN.Size = new System.Drawing.Size(180, 40);
            this.txtboxSN.TabIndex = 17;
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecies.Location = new System.Drawing.Point(57, 194);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(115, 33);
            this.labelSpecies.TabIndex = 6;
            this.labelSpecies.Text = "Species :";
            // 
            // txtboxGender
            // 
            this.txtboxGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxGender.Location = new System.Drawing.Point(273, 303);
            this.txtboxGender.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxGender.Name = "txtboxGender";
            this.txtboxGender.ReadOnly = true;
            this.txtboxGender.Size = new System.Drawing.Size(180, 40);
            this.txtboxGender.TabIndex = 16;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(57, 135);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 33);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name :";
            // 
            // txtboxStatus
            // 
            this.txtboxStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStatus.Location = new System.Drawing.Point(273, 486);
            this.txtboxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxStatus.Name = "txtboxStatus";
            this.txtboxStatus.ReadOnly = true;
            this.txtboxStatus.Size = new System.Drawing.Size(180, 40);
            this.txtboxStatus.TabIndex = 15;
            // 
            // labelAAge
            // 
            this.labelAAge.AutoSize = true;
            this.labelAAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAAge.Location = new System.Drawing.Point(57, 367);
            this.labelAAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAAge.Name = "labelAAge";
            this.labelAAge.Size = new System.Drawing.Size(74, 33);
            this.labelAAge.TabIndex = 8;
            this.labelAAge.Text = "Age :";
            // 
            // txtboxDate
            // 
            this.txtboxDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDate.Location = new System.Drawing.Point(273, 421);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.ReadOnly = true;
            this.txtboxDate.Size = new System.Drawing.Size(180, 40);
            this.txtboxDate.TabIndex = 14;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(57, 308);
            this.labelGender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(110, 33);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(273, 421);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(180, 40);
            this.textBox3.TabIndex = 14;
            // 
            // labelHealthStatus
            // 
            this.labelHealthStatus.AutoSize = true;
            this.labelHealthStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthStatus.Location = new System.Drawing.Point(57, 491);
            this.labelHealthStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHealthStatus.Name = "labelHealthStatus";
            this.labelHealthStatus.Size = new System.Drawing.Size(191, 33);
            this.labelHealthStatus.TabIndex = 10;
            this.labelHealthStatus.Text = "Current Status :";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAge.Location = new System.Drawing.Point(273, 362);
            this.txtboxAge.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.ReadOnly = true;
            this.txtboxAge.Size = new System.Drawing.Size(180, 40);
            this.txtboxAge.TabIndex = 13;
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalDate.Location = new System.Drawing.Point(57, 428);
            this.labelArrivalDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(166, 33);
            this.labelArrivalDate.TabIndex = 11;
            this.labelArrivalDate.Text = "Arrival Date :";
            // 
            // txtboxID
            // 
            this.txtboxID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxID.Location = new System.Drawing.Point(273, 72);
            this.txtboxID.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.ReadOnly = true;
            this.txtboxID.Size = new System.Drawing.Size(180, 40);
            this.txtboxID.TabIndex = 12;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(361, 168);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(178, 46);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // panelWriteReport
            // 
            this.panelWriteReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWriteReport.Controls.Add(this.buttonSubmit);
            this.panelWriteReport.Controls.Add(this.cmbBreathing);
            this.panelWriteReport.Controls.Add(this.cmbUrination);
            this.panelWriteReport.Controls.Add(this.cmbEyes);
            this.panelWriteReport.Controls.Add(this.cmbHydration);
            this.panelWriteReport.Controls.Add(this.cmbAppetite);
            this.panelWriteReport.Controls.Add(this.textBoxTemp);
            this.panelWriteReport.Controls.Add(this.cmbAppearance);
            this.panelWriteReport.Controls.Add(this.txtboxReportDate);
            this.panelWriteReport.Controls.Add(this.labeleyes);
            this.panelWriteReport.Controls.Add(this.labelBreathing);
            this.panelWriteReport.Controls.Add(this.labelUrination);
            this.panelWriteReport.Controls.Add(this.labelAppetite);
            this.panelWriteReport.Controls.Add(this.labelHydrationStatus);
            this.panelWriteReport.Controls.Add(this.labelTemp);
            this.panelWriteReport.Controls.Add(this.labelAppearance);
            this.panelWriteReport.Controls.Add(this.labelReportDate);
            this.panelWriteReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWriteReport.Location = new System.Drawing.Point(689, 22);
            this.panelWriteReport.Margin = new System.Windows.Forms.Padding(6);
            this.panelWriteReport.Name = "panelWriteReport";
            this.panelWriteReport.Size = new System.Drawing.Size(878, 925);
            this.panelWriteReport.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(358, 838);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(138, 42);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // cmbBreathing
            // 
            this.cmbBreathing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreathing.FormattingEnabled = true;
            this.cmbBreathing.Items.AddRange(new object[] {
            "Normal",
            "Labored",
            "Rapid",
            "Noisy"});
            this.cmbBreathing.Location = new System.Drawing.Point(418, 617);
            this.cmbBreathing.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBreathing.Name = "cmbBreathing";
            this.cmbBreathing.Size = new System.Drawing.Size(255, 41);
            this.cmbBreathing.TabIndex = 15;
            // 
            // cmbUrination
            // 
            this.cmbUrination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrination.FormattingEnabled = true;
            this.cmbUrination.Items.AddRange(new object[] {
            "Normal",
            "Diarrhea",
            "Constipation",
            "Abnormal Color"});
            this.cmbUrination.Location = new System.Drawing.Point(418, 722);
            this.cmbUrination.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUrination.Name = "cmbUrination";
            this.cmbUrination.Size = new System.Drawing.Size(255, 41);
            this.cmbUrination.TabIndex = 14;
            // 
            // cmbEyes
            // 
            this.cmbEyes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEyes.FormattingEnabled = true;
            this.cmbEyes.Items.AddRange(new object[] {
            "Clear",
            "Discharge",
            "Swollen",
            "Injured"});
            this.cmbEyes.Location = new System.Drawing.Point(418, 522);
            this.cmbEyes.Margin = new System.Windows.Forms.Padding(6);
            this.cmbEyes.Name = "cmbEyes";
            this.cmbEyes.Size = new System.Drawing.Size(255, 41);
            this.cmbEyes.TabIndex = 13;
            // 
            // cmbHydration
            // 
            this.cmbHydration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHydration.FormattingEnabled = true;
            this.cmbHydration.Items.AddRange(new object[] {
            "Normal",
            "Dehydrated"});
            this.cmbHydration.Location = new System.Drawing.Point(418, 432);
            this.cmbHydration.Margin = new System.Windows.Forms.Padding(6);
            this.cmbHydration.Name = "cmbHydration";
            this.cmbHydration.Size = new System.Drawing.Size(255, 41);
            this.cmbHydration.TabIndex = 12;
            // 
            // cmbAppetite
            // 
            this.cmbAppetite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppetite.FormattingEnabled = true;
            this.cmbAppetite.Items.AddRange(new object[] {
            "Normal ",
            "Decreased",
            "Increased",
            "Not Eating"});
            this.cmbAppetite.Location = new System.Drawing.Point(418, 349);
            this.cmbAppetite.Margin = new System.Windows.Forms.Padding(6);
            this.cmbAppetite.Name = "cmbAppetite";
            this.cmbAppetite.Size = new System.Drawing.Size(255, 41);
            this.cmbAppetite.TabIndex = 11;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(418, 262);
            this.textBoxTemp.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(255, 40);
            this.textBoxTemp.TabIndex = 10;
            // 
            // cmbAppearance
            // 
            this.cmbAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppearance.FormattingEnabled = true;
            this.cmbAppearance.Items.AddRange(new object[] {
            "Normal",
            "Thin",
            "Overweight",
            "Injured",
            "Abnormal Behaviour"});
            this.cmbAppearance.Location = new System.Drawing.Point(418, 179);
            this.cmbAppearance.Margin = new System.Windows.Forms.Padding(6);
            this.cmbAppearance.Name = "cmbAppearance";
            this.cmbAppearance.Size = new System.Drawing.Size(255, 41);
            this.cmbAppearance.TabIndex = 9;
            // 
            // txtboxReportDate
            // 
            this.txtboxReportDate.Location = new System.Drawing.Point(418, 100);
            this.txtboxReportDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxReportDate.Name = "txtboxReportDate";
            this.txtboxReportDate.Size = new System.Drawing.Size(255, 40);
            this.txtboxReportDate.TabIndex = 8;
            // 
            // labeleyes
            // 
            this.labeleyes.AutoSize = true;
            this.labeleyes.Location = new System.Drawing.Point(204, 528);
            this.labeleyes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeleyes.Name = "labeleyes";
            this.labeleyes.Size = new System.Drawing.Size(83, 33);
            this.labeleyes.TabIndex = 7;
            this.labeleyes.Text = "Eyes :";
            // 
            // labelBreathing
            // 
            this.labelBreathing.AutoSize = true;
            this.labelBreathing.Location = new System.Drawing.Point(204, 622);
            this.labelBreathing.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBreathing.Name = "labelBreathing";
            this.labelBreathing.Size = new System.Drawing.Size(139, 33);
            this.labelBreathing.TabIndex = 6;
            this.labelBreathing.Text = "Breathing :";
            // 
            // labelUrination
            // 
            this.labelUrination.AutoSize = true;
            this.labelUrination.Location = new System.Drawing.Point(207, 727);
            this.labelUrination.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUrination.Name = "labelUrination";
            this.labelUrination.Size = new System.Drawing.Size(136, 33);
            this.labelUrination.TabIndex = 5;
            this.labelUrination.Text = "Urination :";
            // 
            // labelAppetite
            // 
            this.labelAppetite.AutoSize = true;
            this.labelAppetite.Location = new System.Drawing.Point(204, 354);
            this.labelAppetite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAppetite.Name = "labelAppetite";
            this.labelAppetite.Size = new System.Drawing.Size(125, 33);
            this.labelAppetite.TabIndex = 4;
            this.labelAppetite.Text = "Appetite :";
            // 
            // labelHydrationStatus
            // 
            this.labelHydrationStatus.AutoSize = true;
            this.labelHydrationStatus.Location = new System.Drawing.Point(204, 438);
            this.labelHydrationStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHydrationStatus.Name = "labelHydrationStatus";
            this.labelHydrationStatus.Size = new System.Drawing.Size(217, 33);
            this.labelHydrationStatus.TabIndex = 3;
            this.labelHydrationStatus.Text = "Hydration Status :";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(204, 268);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(166, 33);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "Temperature :";
            // 
            // labelAppearance
            // 
            this.labelAppearance.AutoSize = true;
            this.labelAppearance.Location = new System.Drawing.Point(204, 185);
            this.labelAppearance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAppearance.Name = "labelAppearance";
            this.labelAppearance.Size = new System.Drawing.Size(160, 33);
            this.labelAppearance.TabIndex = 1;
            this.labelAppearance.Text = "Appearance :";
            // 
            // labelReportDate
            // 
            this.labelReportDate.AutoSize = true;
            this.labelReportDate.Location = new System.Drawing.Point(204, 105);
            this.labelReportDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReportDate.Name = "labelReportDate";
            this.labelReportDate.Size = new System.Drawing.Size(158, 33);
            this.labelReportDate.TabIndex = 0;
            this.labelReportDate.Text = "ReportDate :";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 973);
            this.Controls.Add(this.panelWriteReport);
            this.Controls.Add(this.panelLoadSelectedAnimal);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panelLoadSelectedAnimal.ResumeLayout(false);
            this.panelLoadSelectedAnimal.PerformLayout();
            this.groupBoxAnimalDetails.ResumeLayout(false);
            this.groupBoxAnimalDetails.PerformLayout();
            this.panelWriteReport.ResumeLayout(false);
            this.panelWriteReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelDescribe;
        private System.Windows.Forms.ComboBox cmbSelectAnimal;
        private System.Windows.Forms.Panel panelLoadSelectedAnimal;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelScientificName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAAge;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSpecies;
        private System.Windows.Forms.TextBox txtboxSN;
        private System.Windows.Forms.TextBox txtboxGender;
        private System.Windows.Forms.TextBox txtboxStatus;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelHealthStatus;
        private System.Windows.Forms.GroupBox groupBoxAnimalDetails;
        private System.Windows.Forms.Panel panelWriteReport;
        private System.Windows.Forms.Label labelAppearance;
        private System.Windows.Forms.Label labelReportDate;
        private System.Windows.Forms.Label labeleyes;
        private System.Windows.Forms.Label labelBreathing;
        private System.Windows.Forms.Label labelUrination;
        private System.Windows.Forms.Label labelAppetite;
        private System.Windows.Forms.Label labelHydrationStatus;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.ComboBox cmbAppearance;
        private System.Windows.Forms.TextBox txtboxReportDate;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.ComboBox cmbAppetite;
        private System.Windows.Forms.ComboBox cmbBreathing;
        private System.Windows.Forms.ComboBox cmbUrination;
        private System.Windows.Forms.ComboBox cmbEyes;
        private System.Windows.Forms.ComboBox cmbHydration;
        private System.Windows.Forms.Button buttonSubmit;
    }
}