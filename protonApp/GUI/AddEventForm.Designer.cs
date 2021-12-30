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
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.teamCountTextBox = new System.Windows.Forms.TextBox();
            this.isRelayCheckBox = new System.Windows.Forms.CheckBox();
            this.peopleCountTextBox = new System.Windows.Forms.TextBox();
            this.playerPlaceTextBox = new System.Windows.Forms.TextBox();
            this.individualSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.relayCountTextBox = new System.Windows.Forms.TextBox();
            this.organizationGroupBox = new System.Windows.Forms.GroupBox();
            this.higherRankEventCheckBox = new System.Windows.Forms.CheckBox();
            this.teamSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.matchCountTextBox = new System.Windows.Forms.TextBox();
            this.teamIndividualSportsGroupBox = new System.Windows.Forms.GroupBox();
            this.championsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.showStudentsListBox = new System.Windows.Forms.ListBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.gradeForOrganisationTextBox = new System.Windows.Forms.TextBox();
            this.individualSportsGroupBox.SuspendLayout();
            this.organizationGroupBox.SuspendLayout();
            this.teamSportsGroupBox.SuspendLayout();
            this.teamIndividualSportsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventDateTimePicker.Location = new System.Drawing.Point(12, 112);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(391, 26);
            this.eventDateTimePicker.TabIndex = 3;
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(12, 44);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(391, 28);
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
            this.sportDisciplineComboBox.Size = new System.Drawing.Size(391, 28);
            this.sportDisciplineComboBox.TabIndex = 5;
            this.sportDisciplineComboBox.Text = "Dyscyplina";
            this.sportDisciplineComboBox.SelectedIndexChanged += new System.EventHandler(this.SportDisciplineComboBox_SelectedIndexChanged);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameTextBox.Location = new System.Drawing.Point(409, 12);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.studentNameTextBox.TabIndex = 6;
            this.studentNameTextBox.Text = "Wprowadź nazwisko";
            this.studentNameTextBox.Click += new System.EventHandler(this.StudentNameTextBox_Click_1);
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.StudentNameTextBox_TextChanged);
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(409, 44);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(379, 28);
            this.studentNameComboBox.TabIndex = 7;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(391, 26);
            this.eventNameTextBox.TabIndex = 8;
            this.eventNameTextBox.Text = "Nazwa wydarzenia";
            this.eventNameTextBox.Click += new System.EventHandler(this.EventNameTextBox_Click);
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.EventNameTextBox_TextChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(675, 687);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(390, 42);
            this.addEventButton.TabIndex = 9;
            this.addEventButton.Text = "DODAJ WYDARZENIE";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.Control;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(209, 643);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(60, 42);
            this.resultLabel.TabIndex = 10;
            // 
            // teamCountTextBox
            // 
            this.teamCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamCountTextBox.Location = new System.Drawing.Point(6, 19);
            this.teamCountTextBox.Name = "teamCountTextBox";
            this.teamCountTextBox.Size = new System.Drawing.Size(100, 26);
            this.teamCountTextBox.TabIndex = 11;
            this.teamCountTextBox.Text = "Ilość drużyn";
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
            // 
            // peopleCountTextBox
            // 
            this.peopleCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleCountTextBox.Location = new System.Drawing.Point(217, 19);
            this.peopleCountTextBox.Name = "peopleCountTextBox";
            this.peopleCountTextBox.Size = new System.Drawing.Size(110, 26);
            this.peopleCountTextBox.TabIndex = 14;
            this.peopleCountTextBox.Text = "Ilość osób";
            // 
            // playerPlaceTextBox
            // 
            this.playerPlaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerPlaceTextBox.Location = new System.Drawing.Point(409, 78);
            this.playerPlaceTextBox.Name = "playerPlaceTextBox";
            this.playerPlaceTextBox.Size = new System.Drawing.Size(188, 26);
            this.playerPlaceTextBox.TabIndex = 16;
            this.playerPlaceTextBox.Text = "Zajęte miejsce";
            // 
            // individualSportsGroupBox
            // 
            this.individualSportsGroupBox.AutoSize = true;
            this.individualSportsGroupBox.Controls.Add(this.isRelayCheckBox);
            this.individualSportsGroupBox.Controls.Add(this.peopleCountTextBox);
            this.individualSportsGroupBox.Controls.Add(this.relayCountTextBox);
            this.individualSportsGroupBox.Location = new System.Drawing.Point(12, 144);
            this.individualSportsGroupBox.Name = "individualSportsGroupBox";
            this.individualSportsGroupBox.Size = new System.Drawing.Size(333, 64);
            this.individualSportsGroupBox.TabIndex = 17;
            this.individualSportsGroupBox.TabStop = false;
            // 
            // relayCountTextBox
            // 
            this.relayCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.relayCountTextBox.Location = new System.Drawing.Point(101, 19);
            this.relayCountTextBox.Name = "relayCountTextBox";
            this.relayCountTextBox.Size = new System.Drawing.Size(110, 26);
            this.relayCountTextBox.TabIndex = 13;
            this.relayCountTextBox.Text = "Ilość sztafet";
            // 
            // organizationGroupBox
            // 
            this.organizationGroupBox.AutoSize = true;
            this.organizationGroupBox.Controls.Add(this.gradeForOrganisationTextBox);
            this.organizationGroupBox.Controls.Add(this.higherRankEventCheckBox);
            this.organizationGroupBox.Location = new System.Drawing.Point(12, 356);
            this.organizationGroupBox.Name = "organizationGroupBox";
            this.organizationGroupBox.Size = new System.Drawing.Size(220, 139);
            this.organizationGroupBox.TabIndex = 18;
            this.organizationGroupBox.TabStop = false;
            // 
            // higherRankEventCheckBox
            // 
            this.higherRankEventCheckBox.AutoSize = true;
            this.higherRankEventCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.higherRankEventCheckBox.Location = new System.Drawing.Point(6, 19);
            this.higherRankEventCheckBox.Name = "higherRankEventCheckBox";
            this.higherRankEventCheckBox.Size = new System.Drawing.Size(208, 24);
            this.higherRankEventCheckBox.TabIndex = 0;
            this.higherRankEventCheckBox.Text = "Wydarzenie wyższej rangi";
            this.higherRankEventCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamSportsGroupBox
            // 
            this.teamSportsGroupBox.AutoSize = true;
            this.teamSportsGroupBox.Controls.Add(this.matchCountTextBox);
            this.teamSportsGroupBox.Controls.Add(this.teamCountTextBox);
            this.teamSportsGroupBox.Location = new System.Drawing.Point(12, 214);
            this.teamSportsGroupBox.Name = "teamSportsGroupBox";
            this.teamSportsGroupBox.Size = new System.Drawing.Size(218, 64);
            this.teamSportsGroupBox.TabIndex = 19;
            this.teamSportsGroupBox.TabStop = false;
            // 
            // matchCountTextBox
            // 
            this.matchCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.matchCountTextBox.Location = new System.Drawing.Point(112, 19);
            this.matchCountTextBox.Name = "matchCountTextBox";
            this.matchCountTextBox.Size = new System.Drawing.Size(100, 26);
            this.matchCountTextBox.TabIndex = 20;
            this.matchCountTextBox.Text = "Ilość meczy";
            this.matchCountTextBox.TextChanged += new System.EventHandler(this.MatchCountTextBox_Click);
            // 
            // teamIndividualSportsGroupBox
            // 
            this.teamIndividualSportsGroupBox.AutoSize = true;
            this.teamIndividualSportsGroupBox.Controls.Add(this.championsTypeComboBox);
            this.teamIndividualSportsGroupBox.Location = new System.Drawing.Point(12, 284);
            this.teamIndividualSportsGroupBox.Name = "teamIndividualSportsGroupBox";
            this.teamIndividualSportsGroupBox.Size = new System.Drawing.Size(143, 66);
            this.teamIndividualSportsGroupBox.TabIndex = 22;
            this.teamIndividualSportsGroupBox.TabStop = false;
            this.teamIndividualSportsGroupBox.Visible = false;
            // 
            // championsTypeComboBox
            // 
            this.championsTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.championsTypeComboBox.FormattingEnabled = true;
            this.championsTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.championsTypeComboBox.Name = "championsTypeComboBox";
            this.championsTypeComboBox.Size = new System.Drawing.Size(131, 28);
            this.championsTypeComboBox.TabIndex = 0;
            this.championsTypeComboBox.Text = "Typ mistrzostw";
            // 
            // showStudentsListBox
            // 
            this.showStudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showStudentsListBox.FormattingEnabled = true;
            this.showStudentsListBox.ItemHeight = 20;
            this.showStudentsListBox.Location = new System.Drawing.Point(409, 112);
            this.showStudentsListBox.Name = "showStudentsListBox";
            this.showStudentsListBox.Size = new System.Drawing.Size(379, 404);
            this.showStudentsListBox.TabIndex = 23;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStudentButton.Location = new System.Drawing.Point(603, 78);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(185, 26);
            this.addStudentButton.TabIndex = 24;
            this.addStudentButton.Text = "Dodaj ucznia";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // gradeForOrganisationTextBox
            // 
            this.gradeForOrganisationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradeForOrganisationTextBox.Location = new System.Drawing.Point(7, 50);
            this.gradeForOrganisationTextBox.Name = "gradeForOrganisationTextBox";
            this.gradeForOrganisationTextBox.Size = new System.Drawing.Size(100, 26);
            this.gradeForOrganisationTextBox.TabIndex = 1;
            this.gradeForOrganisationTextBox.Text = "Ocena";
            this.gradeForOrganisationTextBox.Click += new System.EventHandler(this.GradeForOrganisationTextBox_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 741);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.showStudentsListBox);
            this.Controls.Add(this.teamIndividualSportsGroupBox);
            this.Controls.Add(this.teamSportsGroupBox);
            this.Controls.Add(this.organizationGroupBox);
            this.Controls.Add(this.individualSportsGroupBox);
            this.Controls.Add(this.playerPlaceTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.studentNameComboBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.sportDisciplineComboBox);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(this.eventDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEventForm";
            this.Text = "Dodaj wydarzenie";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.individualSportsGroupBox.ResumeLayout(false);
            this.individualSportsGroupBox.PerformLayout();
            this.organizationGroupBox.ResumeLayout(false);
            this.organizationGroupBox.PerformLayout();
            this.teamSportsGroupBox.ResumeLayout(false);
            this.teamSportsGroupBox.PerformLayout();
            this.teamIndividualSportsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.ComboBox sportDisciplineComboBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.ComboBox studentNameComboBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox teamCountTextBox;
        private System.Windows.Forms.CheckBox isRelayCheckBox;
        private System.Windows.Forms.TextBox peopleCountTextBox;
        private System.Windows.Forms.TextBox playerPlaceTextBox;
        private System.Windows.Forms.GroupBox individualSportsGroupBox;
        private System.Windows.Forms.TextBox relayCountTextBox;
        private System.Windows.Forms.GroupBox organizationGroupBox;
        private System.Windows.Forms.CheckBox higherRankEventCheckBox;
        private System.Windows.Forms.GroupBox teamSportsGroupBox;
        private System.Windows.Forms.TextBox matchCountTextBox;
        private System.Windows.Forms.GroupBox teamIndividualSportsGroupBox;
        private System.Windows.Forms.ComboBox championsTypeComboBox;
        private System.Windows.Forms.ListBox showStudentsListBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox gradeForOrganisationTextBox;
    }
}