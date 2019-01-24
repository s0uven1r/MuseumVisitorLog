namespace MuseumLog
{
    partial class MuseumForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.contactInput = new System.Windows.Forms.TextBox();
            this.occuptnInput = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.csvInput = new System.Windows.Forms.Button();
            this.errFName = new System.Windows.Forms.Label();
            this.errContact = new System.Windows.Forms.Label();
            this.errOccuptn = new System.Windows.Forms.Label();
            this.errTxtEmail = new System.Windows.Forms.Label();
            this.newEntryPanel = new System.Windows.Forms.Panel();
            this.tempVisitorID = new System.Windows.Forms.Label();
            this.visitorID = new System.Windows.Forms.Label();
            this.outTimepicker = new System.Windows.Forms.DateTimePicker();
            this.outTimelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errAddr = new System.Windows.Forms.Label();
            this.addrInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errLName = new System.Windows.Forms.Label();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.dailyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.weeklyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dailyReportBtn = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.weeklyReportBtn = new System.Windows.Forms.Button();
            this.dailyListBtn = new System.Windows.Forms.Button();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.csvOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newEntryBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.Label();
            this.newEntryPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contact No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Occupation";
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(127, 41);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(202, 20);
            this.fNameInput.TabIndex = 0;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(127, 129);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(202, 20);
            this.emailInput.TabIndex = 4;
            // 
            // contactInput
            // 
            this.contactInput.Location = new System.Drawing.Point(506, 80);
            this.contactInput.Name = "contactInput";
            this.contactInput.Size = new System.Drawing.Size(191, 20);
            this.contactInput.TabIndex = 3;
            // 
            // occuptnInput
            // 
            this.occuptnInput.Location = new System.Drawing.Point(506, 126);
            this.occuptnInput.Name = "occuptnInput";
            this.occuptnInput.Size = new System.Drawing.Size(191, 20);
            this.occuptnInput.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(629, 245);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 34);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // csvInput
            // 
            this.csvInput.Location = new System.Drawing.Point(148, 245);
            this.csvInput.Name = "csvInput";
            this.csvInput.Size = new System.Drawing.Size(90, 25);
            this.csvInput.TabIndex = 0;
            this.csvInput.Text = "CSV Input";
            this.csvInput.UseVisualStyleBackColor = true;
            this.csvInput.Click += new System.EventHandler(this.CsvInput_Click);
            // 
            // errFName
            // 
            this.errFName.AutoSize = true;
            this.errFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFName.ForeColor = System.Drawing.Color.Red;
            this.errFName.Location = new System.Drawing.Point(335, 28);
            this.errFName.Name = "errFName";
            this.errFName.Size = new System.Drawing.Size(13, 17);
            this.errFName.TabIndex = 18;
            this.errFName.Text = "*";
            this.errFName.Visible = false;
            // 
            // errContact
            // 
            this.errContact.AutoSize = true;
            this.errContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContact.ForeColor = System.Drawing.Color.Red;
            this.errContact.Location = new System.Drawing.Point(503, 103);
            this.errContact.Name = "errContact";
            this.errContact.Size = new System.Drawing.Size(113, 15);
            this.errContact.TabIndex = 16;
            this.errContact.Text = "Enter only numbers";
            this.errContact.Visible = false;
            // 
            // errOccuptn
            // 
            this.errOccuptn.AutoSize = true;
            this.errOccuptn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errOccuptn.ForeColor = System.Drawing.Color.Red;
            this.errOccuptn.Location = new System.Drawing.Point(703, 119);
            this.errOccuptn.Name = "errOccuptn";
            this.errOccuptn.Size = new System.Drawing.Size(13, 17);
            this.errOccuptn.TabIndex = 14;
            this.errOccuptn.Text = "*";
            this.errOccuptn.Visible = false;
            // 
            // errTxtEmail
            // 
            this.errTxtEmail.AutoSize = true;
            this.errTxtEmail.ForeColor = System.Drawing.Color.Red;
            this.errTxtEmail.Location = new System.Drawing.Point(124, 158);
            this.errTxtEmail.Name = "errTxtEmail";
            this.errTxtEmail.Size = new System.Drawing.Size(171, 13);
            this.errTxtEmail.TabIndex = 19;
            this.errTxtEmail.Text = "Enter input in format abc@xyz.com";
            this.errTxtEmail.Visible = false;
            // 
            // newEntryPanel
            // 
            this.newEntryPanel.Controls.Add(this.tempVisitorID);
            this.newEntryPanel.Controls.Add(this.reportPanel);
            this.newEntryPanel.Controls.Add(this.visitorID);
            this.newEntryPanel.Controls.Add(this.outTimepicker);
            this.newEntryPanel.Controls.Add(this.outTimelabel);
            this.newEntryPanel.Controls.Add(this.label6);
            this.newEntryPanel.Controls.Add(this.inTimePicker);
            this.newEntryPanel.Controls.Add(this.errAddr);
            this.newEntryPanel.Controls.Add(this.saveBtn);
            this.newEntryPanel.Controls.Add(this.csvInput);
            this.newEntryPanel.Controls.Add(this.addrInput);
            this.newEntryPanel.Controls.Add(this.label11);
            this.newEntryPanel.Controls.Add(this.errLName);
            this.newEntryPanel.Controls.Add(this.lNameInput);
            this.newEntryPanel.Controls.Add(this.label9);
            this.newEntryPanel.Controls.Add(this.dateToday);
            this.newEntryPanel.Controls.Add(this.label7);
            this.newEntryPanel.Controls.Add(this.label1);
            this.newEntryPanel.Controls.Add(this.label5);
            this.newEntryPanel.Controls.Add(this.errTxtEmail);
            this.newEntryPanel.Controls.Add(this.fNameInput);
            this.newEntryPanel.Controls.Add(this.errContact);
            this.newEntryPanel.Controls.Add(this.errOccuptn);
            this.newEntryPanel.Controls.Add(this.errFName);
            this.newEntryPanel.Controls.Add(this.label2);
            this.newEntryPanel.Controls.Add(this.emailInput);
            this.newEntryPanel.Controls.Add(this.label4);
            this.newEntryPanel.Controls.Add(this.occuptnInput);
            this.newEntryPanel.Controls.Add(this.contactInput);
            this.newEntryPanel.Controls.Add(this.label3);
            this.newEntryPanel.Location = new System.Drawing.Point(6, 19);
            this.newEntryPanel.Name = "newEntryPanel";
            this.newEntryPanel.Size = new System.Drawing.Size(758, 293);
            this.newEntryPanel.TabIndex = 15;
            this.newEntryPanel.Visible = false;
            // 
            // tempVisitorID
            // 
            this.tempVisitorID.AutoSize = true;
            this.tempVisitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempVisitorID.Location = new System.Drawing.Point(147, 11);
            this.tempVisitorID.Name = "tempVisitorID";
            this.tempVisitorID.Size = new System.Drawing.Size(28, 13);
            this.tempVisitorID.TabIndex = 25;
            this.tempVisitorID.Text = "001";
            this.tempVisitorID.Visible = false;
            // 
            // visitorID
            // 
            this.visitorID.AutoSize = true;
            this.visitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorID.Location = new System.Drawing.Point(113, 11);
            this.visitorID.Name = "visitorID";
            this.visitorID.Size = new System.Drawing.Size(28, 13);
            this.visitorID.TabIndex = 24;
            this.visitorID.Text = "001";
            this.visitorID.Visible = false;
            // 
            // outTimepicker
            // 
            this.outTimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outTimepicker.Location = new System.Drawing.Point(506, 177);
            this.outTimepicker.MinDate = new System.DateTime(2019, 1, 19, 0, 0, 0, 0);
            this.outTimepicker.Name = "outTimepicker";
            this.outTimepicker.ShowUpDown = true;
            this.outTimepicker.Size = new System.Drawing.Size(191, 20);
            this.outTimepicker.TabIndex = 23;
            this.outTimepicker.Visible = false;
            // 
            // outTimelabel
            // 
            this.outTimelabel.AutoSize = true;
            this.outTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTimelabel.Location = new System.Drawing.Point(400, 180);
            this.outTimelabel.Name = "outTimelabel";
            this.outTimelabel.Size = new System.Drawing.Size(74, 17);
            this.outTimelabel.TabIndex = 22;
            this.outTimelabel.Text = "Out Time";
            this.outTimelabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Text File Input";
            // 
            // inTimePicker
            // 
            this.inTimePicker.Enabled = false;
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inTimePicker.Location = new System.Drawing.Point(127, 180);
            this.inTimePicker.MinDate = new System.DateTime(2019, 1, 19, 0, 0, 0, 0);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.ShowUpDown = true;
            this.inTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inTimePicker.TabIndex = 21;
            // 
            // errAddr
            // 
            this.errAddr.AutoSize = true;
            this.errAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddr.ForeColor = System.Drawing.Color.Red;
            this.errAddr.Location = new System.Drawing.Point(335, 68);
            this.errAddr.Name = "errAddr";
            this.errAddr.Size = new System.Drawing.Size(13, 17);
            this.errAddr.TabIndex = 17;
            this.errAddr.Text = "*";
            this.errAddr.Visible = false;
            // 
            // addrInput
            // 
            this.addrInput.Location = new System.Drawing.Point(127, 83);
            this.addrInput.Name = "addrInput";
            this.addrInput.Size = new System.Drawing.Size(202, 20);
            this.addrInput.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Address";
            // 
            // errLName
            // 
            this.errLName.AutoSize = true;
            this.errLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLName.ForeColor = System.Drawing.Color.Red;
            this.errLName.Location = new System.Drawing.Point(703, 28);
            this.errLName.Name = "errLName";
            this.errLName.Size = new System.Drawing.Size(13, 17);
            this.errLName.TabIndex = 15;
            this.errLName.Text = "*";
            this.errLName.Visible = false;
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(506, 39);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(191, 20);
            this.lNameInput.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Last Name";
            // 
            // dateToday
            // 
            this.dateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Location = new System.Drawing.Point(626, 9);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(127, 16);
            this.dateToday.TabIndex = 18;
            this.dateToday.Text = "1/13/2019";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "In Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Manual Input";
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.dailyDatePicker);
            this.reportPanel.Controls.Add(this.weeklyDatePicker);
            this.reportPanel.Controls.Add(this.label8);
            this.reportPanel.Controls.Add(this.dailyReportBtn);
            this.reportPanel.Controls.Add(this.fromLabel);
            this.reportPanel.Controls.Add(this.reportDatePicker);
            this.reportPanel.Controls.Add(this.weeklyReportBtn);
            this.reportPanel.Controls.Add(this.dailyListBtn);
            this.reportPanel.Controls.Add(this.reportGridView);
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(716, 328);
            this.reportPanel.TabIndex = 16;
            this.reportPanel.Visible = false;
            // 
            // dailyDatePicker
            // 
            this.dailyDatePicker.Location = new System.Drawing.Point(513, 42);
            this.dailyDatePicker.Name = "dailyDatePicker";
            this.dailyDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dailyDatePicker.TabIndex = 30;
            // 
            // weeklyDatePicker
            // 
            this.weeklyDatePicker.Location = new System.Drawing.Point(264, 41);
            this.weeklyDatePicker.Name = "weeklyDatePicker";
            this.weeklyDatePicker.Size = new System.Drawing.Size(200, 20);
            this.weeklyDatePicker.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Of";
            // 
            // dailyReportBtn
            // 
            this.dailyReportBtn.Location = new System.Drawing.Point(494, 6);
            this.dailyReportBtn.Name = "dailyReportBtn";
            this.dailyReportBtn.Size = new System.Drawing.Size(111, 27);
            this.dailyReportBtn.TabIndex = 27;
            this.dailyReportBtn.Text = "Daily Report";
            this.dailyReportBtn.UseVisualStyleBackColor = true;
            this.dailyReportBtn.Click += new System.EventHandler(this.DailyReportBtn_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(228, 42);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(40, 17);
            this.fromLabel.TabIndex = 26;
            this.fromLabel.Text = "From";
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.Location = new System.Drawing.Point(10, 41);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reportDatePicker.TabIndex = 25;
            // 
            // weeklyReportBtn
            // 
            this.weeklyReportBtn.Location = new System.Drawing.Point(231, 8);
            this.weeklyReportBtn.Name = "weeklyReportBtn";
            this.weeklyReportBtn.Size = new System.Drawing.Size(111, 27);
            this.weeklyReportBtn.TabIndex = 24;
            this.weeklyReportBtn.Text = "Weekly Report";
            this.weeklyReportBtn.UseVisualStyleBackColor = true;
            this.weeklyReportBtn.Click += new System.EventHandler(this.WeeklyReportBtn_Click);
            // 
            // dailyListBtn
            // 
            this.dailyListBtn.Location = new System.Drawing.Point(10, 12);
            this.dailyListBtn.Name = "dailyListBtn";
            this.dailyListBtn.Size = new System.Drawing.Size(111, 27);
            this.dailyListBtn.TabIndex = 23;
            this.dailyListBtn.Text = "List of Visitor";
            this.dailyListBtn.UseVisualStyleBackColor = true;
            this.dailyListBtn.Click += new System.EventHandler(this.DailyListBtn_Click);
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.AllowUserToDeleteRows = false;
            this.reportGridView.AllowUserToResizeColumns = false;
            this.reportGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.reportGridView.Location = new System.Drawing.Point(10, 67);
            this.reportGridView.Name = "reportGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.reportGridView.Size = new System.Drawing.Size(657, 250);
            this.reportGridView.TabIndex = 22;
            this.reportGridView.Visible = false;
            // 
            // csvOpenFileDialog
            // 
            this.csvOpenFileDialog.Filter = "\"CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt\"";
            this.csvOpenFileDialog.RestoreDirectory = true;
            this.csvOpenFileDialog.Title = "Browse Text and CSV Files";
            this.csvOpenFileDialog.ValidateNames = false;
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Location = new System.Drawing.Point(6, 27);
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.Size = new System.Drawing.Size(90, 30);
            this.newEntryBtn.TabIndex = 16;
            this.newEntryBtn.Text = "New Entry";
            this.newEntryBtn.UseVisualStyleBackColor = true;
            this.newEntryBtn.Click += new System.EventHandler(this.NewEntryBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(145, 33);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(225, 20);
            this.searchBox.TabIndex = 17;
            this.searchBox.Tag = "Search By Email";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(373, 25);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(117, 34);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search By Email";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(568, 25);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(129, 34);
            this.reportBtn.TabIndex = 19;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newEntryBtn);
            this.groupBox1.Controls.Add(this.reportBtn);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 71);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultText);
            this.groupBox2.Controls.Add(this.newEntryPanel);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 353);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Entry";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(221, 122);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(246, 26);
            this.resultText.TabIndex = 22;
            this.resultText.Text = "Museum Management";
            this.resultText.Visible = false;
            // 
            // MuseumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MuseumForm";
            this.Text = "Museum Visitor\'s Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MuseumForm_Closed);
            this.Load += new System.EventHandler(this.MuseumForm_Load);
            this.newEntryPanel.ResumeLayout(false);
            this.newEntryPanel.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox occuptnInput;
        private System.Windows.Forms.TextBox contactInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button csvInput;
        private System.Windows.Forms.Label errFName;
        private System.Windows.Forms.Label errContact;
        private System.Windows.Forms.Label errOccuptn;
        private System.Windows.Forms.Label errTxtEmail;
        private System.Windows.Forms.Panel newEntryPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.Label errAddr;
        private System.Windows.Forms.TextBox addrInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errLName;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.OpenFileDialog csvOpenFileDialog;
        private System.Windows.Forms.Button newEntryBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button dailyListBtn;
        private System.Windows.Forms.Button weeklyReportBtn;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.DateTimePicker outTimepicker;
        private System.Windows.Forms.Label outTimelabel;
        private System.Windows.Forms.Label visitorID;
        private System.Windows.Forms.Label tempVisitorID;
        private System.Windows.Forms.DateTimePicker reportDatePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker dailyDatePicker;
        private System.Windows.Forms.DateTimePicker weeklyDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dailyReportBtn;
    }
}

