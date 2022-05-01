namespace protonApp.GUI
{
    partial class AddEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sportDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.isRelayCheckBox = new System.Windows.Forms.CheckBox();
            this.individualSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.peopleCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.relayCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organizationGroupBox = new System.Windows.Forms.GroupBox();
            this.loggingCheckBox = new System.Windows.Forms.CheckBox();
            this.gradeForOrganizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.higherRankEventCheckBox = new System.Windows.Forms.CheckBox();
            this.teamSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.teamCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.matchCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teamIndividualSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.championsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.playerPlaceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentsToAddCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addedStudentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.individualSportsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relayCountNumericUpDown)).BeginInit();
            this.organizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeForOrganizationNumericUpDown)).BeginInit();
            this.teamSportsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCountNumericUpDown)).BeginInit();
            this.teamIndividualSportsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPlaceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventDateTimePicker.Location = new System.Drawing.Point(12, 112);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(454, 26);
            this.eventDateTimePicker.TabIndex = 3;
            this.eventDateTimePicker.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(12, 44);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(454, 28);
            this.eventTypeComboBox.TabIndex = 4;
            this.eventTypeComboBox.Text = "Typ wydarzenia";
            this.eventTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.EventTypeComboBox_SelectedIndexChanged);
            // 
            // sportDisciplineComboBox
            // 
            this.sportDisciplineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sportDisciplineComboBox.FormattingEnabled = true;
            this.sportDisciplineComboBox.Location = new System.Drawing.Point(12, 78);
            this.sportDisciplineComboBox.Name = "sportDisciplineComboBox";
            this.sportDisciplineComboBox.Size = new System.Drawing.Size(454, 28);
            this.sportDisciplineComboBox.TabIndex = 5;
            this.sportDisciplineComboBox.Text = "Dyscyplina";
            this.sportDisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.SportDisciplineComboBox_SelectedIndexChanged);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameTextBox.Location = new System.Drawing.Point(589, 12);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(493, 26);
            this.studentNameTextBox.TabIndex = 6;
            this.studentNameTextBox.Text = "Wprowadź nazwisko";
            this.studentNameTextBox.Click += new System.EventHandler(this.StudentNameTextBox_Click);
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.StudentNameTextBox_TextChanged);
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(454, 26);
            this.eventNameTextBox.TabIndex = 8;
            this.eventNameTextBox.Text = "Nazwa wydarzenia";
            this.eventNameTextBox.Click += new System.EventHandler(this.EventNameTextBox_Click);
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.EventNameTextBox_TextChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(12, 574);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(1070, 40);
            this.addEventButton.TabIndex = 9;
            this.addEventButton.Text = "DODAJ WYDARZENIE";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // isRelayCheckBox
            // 
            this.isRelayCheckBox.AutoSize = true;
            this.isRelayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isRelayCheckBox.Location = new System.Drawing.Point(6, 21);
            this.isRelayCheckBox.Name = "isRelayCheckBox";
            this.isRelayCheckBox.Size = new System.Drawing.Size(89, 24);
            this.isRelayCheckBox.TabIndex = 12;
            this.isRelayCheckBox.Text = "Sztafeta";
            this.isRelayCheckBox.UseVisualStyleBackColor = true;
            this.isRelayCheckBox.CheckedChanged += new System.EventHandler(this.IsRelayCheckBox_CheckedChanged);
            // 
            // individualSportsGroupBox
            // 
            this.individualSportsGroupBox.AutoSize = true;
            this.individualSportsGroupBox.Controls.Add(this.peopleCountNumericUpDown);
            this.individualSportsGroupBox.Controls.Add(this.relayCountNumericUpDown);
            this.individualSportsGroupBox.Controls.Add(this.label2);
            this.individualSportsGroupBox.Controls.Add(this.isRelayCheckBox);
            this.individualSportsGroupBox.Controls.Add(this.label1);
            this.individualSportsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.individualSportsGroupBox.Location = new System.Drawing.Point(12, 144);
            this.individualSportsGroupBox.Name = "individualSportsGroupBox";
            this.individualSportsGroupBox.Size = new System.Drawing.Size(224, 131);
            this.individualSportsGroupBox.TabIndex = 17;
            this.individualSportsGroupBox.TabStop = false;
            this.individualSportsGroupBox.Text = "Dyscypliny indywidualne";
            // 
            // peopleCountNumericUpDown
            // 
            this.peopleCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleCountNumericUpDown.Location = new System.Drawing.Point(107, 83);
            this.peopleCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.peopleCountNumericUpDown.Name = "peopleCountNumericUpDown";
            this.peopleCountNumericUpDown.Size = new System.Drawing.Size(111, 26);
            this.peopleCountNumericUpDown.TabIndex = 30;
            // 
            // relayCountNumericUpDown
            // 
            this.relayCountNumericUpDown.Enabled = false;
            this.relayCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.relayCountNumericUpDown.Location = new System.Drawing.Point(107, 51);
            this.relayCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.relayCountNumericUpDown.Name = "relayCountNumericUpDown";
            this.relayCountNumericUpDown.Size = new System.Drawing.Size(111, 26);
            this.relayCountNumericUpDown.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ilość osób";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ilość sztafet";
            // 
            // organizationGroupBox
            // 
            this.organizationGroupBox.AutoSize = true;
            this.organizationGroupBox.Controls.Add(this.loggingCheckBox);
            this.organizationGroupBox.Controls.Add(this.gradeForOrganizationNumericUpDown);
            this.organizationGroupBox.Controls.Add(this.label5);
            this.organizationGroupBox.Controls.Add(this.higherRankEventCheckBox);
            this.organizationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.organizationGroupBox.Location = new System.Drawing.Point(242, 281);
            this.organizationGroupBox.Name = "organizationGroupBox";
            this.organizationGroupBox.Size = new System.Drawing.Size(224, 131);
            this.organizationGroupBox.TabIndex = 18;
            this.organizationGroupBox.TabStop = false;
            this.organizationGroupBox.Text = "Organizacja lub sędziowanie";
            // 
            // loggingCheckBox
            // 
            this.loggingCheckBox.AutoSize = true;
            this.loggingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loggingCheckBox.Location = new System.Drawing.Point(10, 51);
            this.loggingCheckBox.Name = "loggingCheckBox";
            this.loggingCheckBox.Size = new System.Drawing.Size(137, 24);
            this.loggingCheckBox.TabIndex = 32;
            this.loggingCheckBox.Text = "Protokołowanie";
            this.loggingCheckBox.UseVisualStyleBackColor = true;
            this.loggingCheckBox.CheckedChanged += new System.EventHandler(this.LoggingCheckBox_CheckedChanged);
            // 
            // gradeForOrganizationNumericUpDown
            // 
            this.gradeForOrganizationNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradeForOrganizationNumericUpDown.Location = new System.Drawing.Point(68, 81);
            this.gradeForOrganizationNumericUpDown.Name = "gradeForOrganizationNumericUpDown";
            this.gradeForOrganizationNumericUpDown.Size = new System.Drawing.Size(150, 26);
            this.gradeForOrganizationNumericUpDown.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ocena";
            // 
            // higherRankEventCheckBox
            // 
            this.higherRankEventCheckBox.AutoSize = true;
            this.higherRankEventCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.higherRankEventCheckBox.Location = new System.Drawing.Point(10, 21);
            this.higherRankEventCheckBox.Name = "higherRankEventCheckBox";
            this.higherRankEventCheckBox.Size = new System.Drawing.Size(208, 24);
            this.higherRankEventCheckBox.TabIndex = 0;
            this.higherRankEventCheckBox.Text = "Wydarzenie wyższej rangi";
            this.higherRankEventCheckBox.UseVisualStyleBackColor = true;
            this.higherRankEventCheckBox.CheckedChanged += new System.EventHandler(this.HigherRankEventCheckBox_CheckedChanged);
            // 
            // teamSportsGroupBox
            // 
            this.teamSportsGroupBox.AutoSize = true;
            this.teamSportsGroupBox.Controls.Add(this.teamCountNumericUpDown);
            this.teamSportsGroupBox.Controls.Add(this.matchCountNumericUpDown);
            this.teamSportsGroupBox.Controls.Add(this.label4);
            this.teamSportsGroupBox.Controls.Add(this.label3);
            this.teamSportsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamSportsGroupBox.Location = new System.Drawing.Point(242, 144);
            this.teamSportsGroupBox.Name = "teamSportsGroupBox";
            this.teamSportsGroupBox.Size = new System.Drawing.Size(224, 131);
            this.teamSportsGroupBox.TabIndex = 19;
            this.teamSportsGroupBox.TabStop = false;
            this.teamSportsGroupBox.Text = "Dyscypliny zespołowe";
            // 
            // teamCountNumericUpDown
            // 
            this.teamCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamCountNumericUpDown.Location = new System.Drawing.Point(105, 52);
            this.teamCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.teamCountNumericUpDown.Name = "teamCountNumericUpDown";
            this.teamCountNumericUpDown.Size = new System.Drawing.Size(113, 26);
            this.teamCountNumericUpDown.TabIndex = 33;
            // 
            // matchCountNumericUpDown
            // 
            this.matchCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.matchCountNumericUpDown.Location = new System.Drawing.Point(105, 20);
            this.matchCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.matchCountNumericUpDown.Name = "matchCountNumericUpDown";
            this.matchCountNumericUpDown.Size = new System.Drawing.Size(113, 26);
            this.matchCountNumericUpDown.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ilość drużyn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ilość meczy";
            // 
            // teamIndividualSportsGroupBox
            // 
            this.teamIndividualSportsGroupBox.Controls.Add(this.championsTypeComboBox);
            this.teamIndividualSportsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamIndividualSportsGroupBox.Location = new System.Drawing.Point(12, 281);
            this.teamIndividualSportsGroupBox.Name = "teamIndividualSportsGroupBox";
            this.teamIndividualSportsGroupBox.Size = new System.Drawing.Size(224, 131);
            this.teamIndividualSportsGroupBox.TabIndex = 22;
            this.teamIndividualSportsGroupBox.TabStop = false;
            this.teamIndividualSportsGroupBox.Text = "Dyscypliny indywidualne drużynowo";
            // 
            // championsTypeComboBox
            // 
            this.championsTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.championsTypeComboBox.FormattingEnabled = true;
            this.championsTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.championsTypeComboBox.Name = "championsTypeComboBox";
            this.championsTypeComboBox.Size = new System.Drawing.Size(212, 28);
            this.championsTypeComboBox.TabIndex = 0;
            this.championsTypeComboBox.Text = "Typ mistrzostw";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStudentButton.Location = new System.Drawing.Point(476, 77);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(300, 28);
            this.addStudentButton.TabIndex = 24;
            this.addStudentButton.Text = "Dodaj ucznia";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(472, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(472, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 33);
            this.label7.TabIndex = 26;
            this.label7.Text = "Odnalezieni uczniowie";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(472, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Zajęte miejsce";
            // 
            // playerPlaceNumericUpDown
            // 
            this.playerPlaceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerPlaceNumericUpDown.Location = new System.Drawing.Point(589, 45);
            this.playerPlaceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.playerPlaceNumericUpDown.Name = "playerPlaceNumericUpDown";
            this.playerPlaceNumericUpDown.Size = new System.Drawing.Size(493, 26);
            this.playerPlaceNumericUpDown.TabIndex = 28;
            // 
            // studentsToAddCheckedListBox
            // 
            this.studentsToAddCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentsToAddCheckedListBox.FormattingEnabled = true;
            this.studentsToAddCheckedListBox.Location = new System.Drawing.Point(476, 144);
            this.studentsToAddCheckedListBox.Name = "studentsToAddCheckedListBox";
            this.studentsToAddCheckedListBox.Size = new System.Drawing.Size(300, 424);
            this.studentsToAddCheckedListBox.TabIndex = 29;
            this.studentsToAddCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StudentsToAddCheckedListBox_ItemCheck);
            this.studentsToAddCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsToAddCheckedListBox_SelectedIndexChanged);
            // 
            // addedStudentsCheckedListBox
            // 
            this.addedStudentsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addedStudentsCheckedListBox.FormattingEnabled = true;
            this.addedStudentsCheckedListBox.Location = new System.Drawing.Point(782, 144);
            this.addedStudentsCheckedListBox.Name = "addedStudentsCheckedListBox";
            this.addedStudentsCheckedListBox.Size = new System.Drawing.Size(300, 424);
            this.addedStudentsCheckedListBox.TabIndex = 30;
            this.addedStudentsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AddedStudentsCheckedListBox_ItemCheck);
            this.addedStudentsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.addedStudentsCheckedListBox_SelectedIndexChanged);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Enabled = false;
            this.deleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteStudentButton.Location = new System.Drawing.Point(782, 77);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(300, 28);
            this.deleteStudentButton.TabIndex = 31;
            this.deleteStudentButton.Text = "Usuń ucznia";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(782, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "Dodani uczniowie";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 627);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.addedStudentsCheckedListBox);
            this.Controls.Add(this.studentsToAddCheckedListBox);
            this.Controls.Add(this.playerPlaceNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.teamIndividualSportsGroupBox);
            this.Controls.Add(this.teamSportsGroupBox);
            this.Controls.Add(this.organizationGroupBox);
            this.Controls.Add(this.individualSportsGroupBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.sportDisciplineComboBox);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(this.eventDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEventForm";
            this.Text = "Dodaj wydarzenie";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.individualSportsGroupBox.ResumeLayout(false);
            this.individualSportsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relayCountNumericUpDown)).EndInit();
            this.organizationGroupBox.ResumeLayout(false);
            this.organizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeForOrganizationNumericUpDown)).EndInit();
            this.teamSportsGroupBox.ResumeLayout(false);
            this.teamSportsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCountNumericUpDown)).EndInit();
            this.teamIndividualSportsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerPlaceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.ComboBox sportDisciplineComboBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.CheckBox isRelayCheckBox;
        private System.Windows.Forms.GroupBox individualSportsGroupBox;
        private System.Windows.Forms.GroupBox organizationGroupBox;
        private System.Windows.Forms.CheckBox higherRankEventCheckBox;
        private System.Windows.Forms.GroupBox teamSportsGroupBox;
        private System.Windows.Forms.GroupBox teamIndividualSportsGroupBox;
        private System.Windows.Forms.ComboBox championsTypeComboBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown playerPlaceNumericUpDown;
        private System.Windows.Forms.NumericUpDown peopleCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown relayCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown gradeForOrganizationNumericUpDown;
        private System.Windows.Forms.NumericUpDown teamCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown matchCountNumericUpDown;
        private System.Windows.Forms.CheckedListBox studentsToAddCheckedListBox;
        private System.Windows.Forms.CheckedListBox addedStudentsCheckedListBox;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox loggingCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}