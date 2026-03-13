namespace ZooManagementSystem
{
    partial class PickDateTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tlpTickets = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAdultQty = new System.Windows.Forms.Label();
            this.lblChildQty = new System.Windows.Forms.Label();
            this.btnChildMinus = new System.Windows.Forms.Button();
            this.btnChildPlus = new System.Windows.Forms.Button();
            this.btnAdultMinus = new System.Windows.Forms.Button();
            this.btnAdultPlus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tlpTickets.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Zoo Tickets";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.Location = new System.Drawing.Point(95, 118);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.MenuBar;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.AutoSize = true;
            this.lblDateDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDisplay.Location = new System.Drawing.Point(331, 460);
            this.lblDateDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(100, 38);
            this.lblDateDisplay.TabIndex = 3;
            this.lblDateDisplay.Text = "label2";
            this.lblDateDisplay.Visible = false;
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddBasket.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.Location = new System.Drawing.Point(402, 555);
            this.btnAddBasket.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(214, 54);
            this.btnAddBasket.TabIndex = 5;
            this.btnAddBasket.Text = "Add To Basket";
            this.btnAddBasket.UseVisualStyleBackColor = false;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(835, 456);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 45);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label";
            this.lblTotal.Visible = false;
            // 
            // tlpTickets
            // 
            this.tlpTickets.BackColor = System.Drawing.Color.Lavender;
            this.tlpTickets.ColumnCount = 3;
            this.tlpTickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.95918F));
            this.tlpTickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.04082F));
            this.tlpTickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tlpTickets.Controls.Add(this.panel6, 2, 1);
            this.tlpTickets.Controls.Add(this.panel5, 1, 1);
            this.tlpTickets.Controls.Add(this.panel4, 0, 1);
            this.tlpTickets.Controls.Add(this.panel3, 2, 0);
            this.tlpTickets.Controls.Add(this.panel2, 1, 0);
            this.tlpTickets.Controls.Add(this.panel1, 0, 0);
            this.tlpTickets.Location = new System.Drawing.Point(571, 118);
            this.tlpTickets.Margin = new System.Windows.Forms.Padding(4);
            this.tlpTickets.Name = "tlpTickets";
            this.tlpTickets.RowCount = 2;
            this.tlpTickets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.80676F));
            this.tlpTickets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.19324F));
            this.tlpTickets.Size = new System.Drawing.Size(510, 310);
            this.tlpTickets.TabIndex = 7;
            this.tlpTickets.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblAdultQty);
            this.panel6.Controls.Add(this.lblChildQty);
            this.panel6.Controls.Add(this.btnChildMinus);
            this.panel6.Controls.Add(this.btnChildPlus);
            this.panel6.Controls.Add(this.btnAdultMinus);
            this.panel6.Controls.Add(this.btnAdultPlus);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(269, 65);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 241);
            this.panel6.TabIndex = 5;
            // 
            // lblAdultQty
            // 
            this.lblAdultQty.AutoSize = true;
            this.lblAdultQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultQty.Location = new System.Drawing.Point(98, 66);
            this.lblAdultQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdultQty.Name = "lblAdultQty";
            this.lblAdultQty.Size = new System.Drawing.Size(24, 25);
            this.lblAdultQty.TabIndex = 10;
            this.lblAdultQty.Text = "0";
            // 
            // lblChildQty
            // 
            this.lblChildQty.AutoSize = true;
            this.lblChildQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildQty.Location = new System.Drawing.Point(98, 156);
            this.lblChildQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildQty.Name = "lblChildQty";
            this.lblChildQty.Size = new System.Drawing.Size(24, 25);
            this.lblChildQty.TabIndex = 9;
            this.lblChildQty.Text = "0";
            // 
            // btnChildMinus
            // 
            this.btnChildMinus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildMinus.Location = new System.Drawing.Point(172, 146);
            this.btnChildMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildMinus.Name = "btnChildMinus";
            this.btnChildMinus.Size = new System.Drawing.Size(55, 44);
            this.btnChildMinus.TabIndex = 3;
            this.btnChildMinus.Text = "-";
            this.btnChildMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChildMinus.UseVisualStyleBackColor = true;
            this.btnChildMinus.Click += new System.EventHandler(this.btnChildMinus_Click);
            // 
            // btnChildPlus
            // 
            this.btnChildPlus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChildPlus.Location = new System.Drawing.Point(18, 142);
            this.btnChildPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildPlus.Name = "btnChildPlus";
            this.btnChildPlus.Size = new System.Drawing.Size(50, 44);
            this.btnChildPlus.TabIndex = 2;
            this.btnChildPlus.Text = "+";
            this.btnChildPlus.UseVisualStyleBackColor = true;
            this.btnChildPlus.Click += new System.EventHandler(this.btnChildPlus_Click);
            // 
            // btnAdultMinus
            // 
            this.btnAdultMinus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultMinus.Location = new System.Drawing.Point(172, 56);
            this.btnAdultMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdultMinus.Name = "btnAdultMinus";
            this.btnAdultMinus.Size = new System.Drawing.Size(55, 44);
            this.btnAdultMinus.TabIndex = 1;
            this.btnAdultMinus.Text = "-";
            this.btnAdultMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdultMinus.UseVisualStyleBackColor = true;
            this.btnAdultMinus.Click += new System.EventHandler(this.btnAdultMinus_Click);
            // 
            // btnAdultPlus
            // 
            this.btnAdultPlus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultPlus.Location = new System.Drawing.Point(18, 56);
            this.btnAdultPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdultPlus.Name = "btnAdultPlus";
            this.btnAdultPlus.Size = new System.Drawing.Size(50, 44);
            this.btnAdultPlus.TabIndex = 0;
            this.btnAdultPlus.Text = "+";
            this.btnAdultPlus.UseVisualStyleBackColor = true;
            this.btnAdultPlus.Click += new System.EventHandler(this.btnAdultPlus_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(131, 65);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 241);
            this.panel5.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "£24.50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 36);
            this.label9.TabIndex = 11;
            this.label9.Text = "£35.00";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 241);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adult";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Child";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(269, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 53);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10.9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(131, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 53);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 53);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Purchased Date :";
            this.label2.Visible = false;
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(13, 25);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(56, 58);
            this.guna2CircleButton1.TabIndex = 68;
            this.guna2CircleButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlpTickets);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PickDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickDateTime";
            this.tlpTickets.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDateDisplay;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tlpTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdultPlus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdultMinus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChildMinus;
        private System.Windows.Forms.Button btnChildPlus;
        private System.Windows.Forms.Label lblChildQty;
        // private System.Windows.Forms.Label SubAdult;
        private System.Windows.Forms.Label lblAdultQty;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}