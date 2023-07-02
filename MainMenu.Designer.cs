
namespace HotelManagement
{
    partial class MainMenu
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchCustDetails = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchDate = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topRightPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Teal;
            this.welcomeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Location = new System.Drawing.Point(4, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(166, 35);
            this.welcomeLabel.TabIndex = 36;
            this.welcomeLabel.Text = "Καλώς ήρθες";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(216, 529);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.icon4;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(9, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Αρχική";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(9, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Αναζήτηση Κρατήσεων";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(9, 248);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Αναζήτηση Δωματίων";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // topRightPanel
            // 
            this.topRightPanel.Controls.Add(this.welcomeLabel);
            this.topRightPanel.Location = new System.Drawing.Point(801, 10);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(325, 38);
            this.topRightPanel.TabIndex = 38;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchCustDetails);
            this.searchPanel.Controls.Add(this.label12);
            this.searchPanel.Controls.Add(this.surnameField);
            this.searchPanel.Controls.Add(this.label10);
            this.searchPanel.Controls.Add(this.emailField);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.phoneField);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.nameField);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.typeCombo);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.searchDate);
            this.searchPanel.Controls.Add(this.monthBox);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.yearBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.dateBox);
            this.searchPanel.Location = new System.Drawing.Point(225, 54);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(901, 485);
            this.searchPanel.TabIndex = 39;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // searchCustDetails
            // 
            this.searchCustDetails.BackColor = System.Drawing.Color.White;
            this.searchCustDetails.Font = new System.Drawing.Font("Yu Gothic UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.searchCustDetails.Location = new System.Drawing.Point(712, 237);
            this.searchCustDetails.Margin = new System.Windows.Forms.Padding(4);
            this.searchCustDetails.Name = "searchCustDetails";
            this.searchCustDetails.Size = new System.Drawing.Size(77, 22);
            this.searchCustDetails.TabIndex = 57;
            this.searchCustDetails.Text = "Ευρέση";
            this.searchCustDetails.UseVisualStyleBackColor = false;
            this.searchCustDetails.Click += new System.EventHandler(this.searchCustDetails_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(232, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 56;
            this.label12.Text = "Επώνυμο";
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.surnameField.Location = new System.Drawing.Point(207, 239);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(142, 24);
            this.surnameField.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(569, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "E-mail";
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.emailField.Location = new System.Drawing.Point(533, 238);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(139, 24);
            this.emailField.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(411, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Κινητό";
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.phoneField.Location = new System.Drawing.Point(399, 238);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(96, 24);
            this.phoneField.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(69, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Όνομα";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.nameField.Location = new System.Drawing.Point(31, 240);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(148, 24);
            this.nameField.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Αναζήτηση με στοιχεία πελάτη";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Τύπος Ημερομηνίας";
            // 
            // typeCombo
            // 
            this.typeCombo.DisplayMember = "1";
            this.typeCombo.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Ημερομηνία Κράτησης",
            "Ημερομηνία Άφιξης"});
            this.typeCombo.Location = new System.Drawing.Point(31, 93);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(148, 23);
            this.typeCombo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(391, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Μήνας";
            // 
            // searchDate
            // 
            this.searchDate.BackColor = System.Drawing.Color.White;
            this.searchDate.Font = new System.Drawing.Font("Yu Gothic UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.searchDate.Location = new System.Drawing.Point(712, 91);
            this.searchDate.Margin = new System.Windows.Forms.Padding(4);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(77, 22);
            this.searchDate.TabIndex = 13;
            this.searchDate.Text = "Ευρέση";
            this.searchDate.UseVisualStyleBackColor = false;
            this.searchDate.Click += new System.EventHandler(this.searchDate_Click);
            // 
            // monthBox
            // 
            this.monthBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "01 - Ιανουάριος",
            "02 - Φεβρουάριος",
            "03 - Μάρτιος",
            "04 - Απρίλιος",
            "05 - Μάϊος",
            "06 - Ιούνιος",
            "07 - Ιούλιος",
            "08 - Αύγουστος",
            "09 - Σεπτέμβριος",
            "10 - Οκτώβριος",
            "11 - Νοέμβριος",
            "12 - Δεκέμβριος"});
            this.monthBox.Location = new System.Drawing.Point(367, 92);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(121, 23);
            this.monthBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(542, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Έτος";
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.yearBox.Location = new System.Drawing.Point(542, 92);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(55, 23);
            this.yearBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(239, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ημέρα";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Αναζήτηση με Ημερομηνία Check-in";
            // 
            // dateBox
            // 
            this.dateBox.DisplayMember = "1";
            this.dateBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dateBox.Location = new System.Drawing.Point(235, 93);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(76, 23);
            this.dateBox.TabIndex = 2;
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.topRightPanel);
            this.employeePanel.Controls.Add(this.flowLayoutPanel1);
            this.employeePanel.Controls.Add(this.resultsPanel);
            this.employeePanel.Controls.Add(this.searchPanel);
            this.employeePanel.Location = new System.Drawing.Point(12, 3);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(1129, 551);
            this.employeePanel.TabIndex = 40;
            this.employeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.dataGridView1);
            this.resultsPanel.Controls.Add(this.resultsLabel);
            this.resultsPanel.Location = new System.Drawing.Point(225, 53);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(901, 485);
            this.resultsPanel.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.Location = new System.Drawing.Point(18, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 309);
            this.dataGridView1.TabIndex = 38;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.Teal;
            this.resultsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.resultsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.resultsLabel.Location = new System.Drawing.Point(13, 27);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(236, 35);
            this.resultsLabel.TabIndex = 37;
            this.resultsLabel.Text = "Αποτελέσματα για:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1153, 566);
            this.Controls.Add(this.employeePanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topRightPanel.ResumeLayout(false);
            this.topRightPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button searchDate;
        private System.Windows.Forms.Button searchCustDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label resultsLabel;
    }
}