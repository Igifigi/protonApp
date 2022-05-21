
namespace protonApp.GUI
{
    partial class NewMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.NewsLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SubmitIssueButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EventPage = new System.Windows.Forms.TabPage();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.RefreshEventsButton = new System.Windows.Forms.Button();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.EventsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.StudentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.RefreshStudentsButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.RankingPage = new System.Windows.Forms.TabPage();
            this.RefreshRankingButton = new System.Windows.Forms.Button();
            this.CreateRankingPDFButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectSexComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfStudentsToDisplayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClassRankingListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IndividualRankingListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.CommitConnectionStringButton = new System.Windows.Forms.Button();
            this.FullConnectionStringTextBox = new System.Windows.Forms.RichTextBox();
            this.ConfirmChangesButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetValueButton = new System.Windows.Forms.Button();
            this.DirectDatabaseQueryButton = new System.Windows.Forms.Button();
            this.DeleteValueButton = new System.Windows.Forms.Button();
            this.SelectValueComboBox = new System.Windows.Forms.ComboBox();
            this.EditValueButton = new System.Windows.Forms.Button();
            this.AddValueButton = new System.Windows.Forms.Button();
            this.InsertValueTextBox = new System.Windows.Forms.TextBox();
            this.SelectKeyComboBox = new System.Windows.Forms.ComboBox();
            this.MainTabControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EventPage.SuspendLayout();
            this.StudentsPage.SuspendLayout();
            this.RankingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStudentsToDisplayNumericUpDown)).BeginInit();
            this.SettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.EventPage);
            this.MainTabControl.Controls.Add(this.StudentsPage);
            this.MainTabControl.Controls.Add(this.RankingPage);
            this.MainTabControl.Controls.Add(this.SettingsPage);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(908, 756);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            //this.MainTabControl.TabIndexChanged += new System.EventHandler(this.MainTabControl_TabIndexChanged);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.label15);
            this.MainPage.Controls.Add(this.NewsLabel);
            this.MainPage.Controls.Add(this.VersionLabel);
            this.MainPage.Controls.Add(this.HelpButton);
            this.MainPage.Controls.Add(this.SubmitIssueButton);
            this.MainPage.Controls.Add(this.pictureBox1);
            this.MainPage.Controls.Add(this.label12);
            this.MainPage.Controls.Add(this.label11);
            this.MainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainPage.Location = new System.Drawing.Point(4, 38);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(900, 714);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Strona główna";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(888, 68);
            this.label15.TabIndex = 21;
            this.label15.Text = "Aktualności:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewsLabel
            // 
            this.NewsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewsLabel.Location = new System.Drawing.Point(6, 459);
            this.NewsLabel.Name = "NewsLabel";
            this.NewsLabel.Size = new System.Drawing.Size(891, 252);
            this.NewsLabel.TabIndex = 20;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VersionLabel.Location = new System.Drawing.Point(480, 365);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(152, 23);
            this.VersionLabel.TabIndex = 19;
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpButton.Location = new System.Drawing.Point(638, 268);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(256, 57);
            this.HelpButton.TabIndex = 18;
            this.HelpButton.Text = "Pomoc";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SubmitIssueButton
            // 
            this.SubmitIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitIssueButton.Location = new System.Drawing.Point(638, 331);
            this.SubmitIssueButton.Name = "SubmitIssueButton";
            this.SubmitIssueButton.Size = new System.Drawing.Size(256, 57);
            this.SubmitIssueButton.TabIndex = 17;
            this.SubmitIssueButton.Text = "Zgłoś błąd";
            this.SubmitIssueButton.UseVisualStyleBackColor = true;
            this.SubmitIssueButton.Click += new System.EventHandler(this.SubmitIssueButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(6, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(626, 196);
            this.label12.TabIndex = 15;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Square721 BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(626, 189);
            this.label11.TabIndex = 14;
            this.label11.Text = "Witaj w aplikacji\r\nPROTON!";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventPage
            // 
            this.EventPage.Controls.Add(this.DeleteEventButton);
            this.EventPage.Controls.Add(this.EditEventButton);
            this.EventPage.Controls.Add(this.RefreshEventsButton);
            this.EventPage.Controls.Add(this.AddEventButton);
            this.EventPage.Controls.Add(this.EventsCheckedListBox);
            this.EventPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventPage.Location = new System.Drawing.Point(4, 38);
            this.EventPage.Name = "EventPage";
            this.EventPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventPage.Size = new System.Drawing.Size(900, 714);
            this.EventPage.TabIndex = 1;
            this.EventPage.Text = "Wydarzenia";
            this.EventPage.UseVisualStyleBackColor = true;
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.Enabled = false;
            this.DeleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteEventButton.Location = new System.Drawing.Point(725, 358);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(172, 169);
            this.DeleteEventButton.TabIndex = 25;
            this.DeleteEventButton.Text = "Usuń wydarzenie";
            this.DeleteEventButton.UseVisualStyleBackColor = true;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // EditEventButton
            // 
            this.EditEventButton.Enabled = false;
            this.EditEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditEventButton.Location = new System.Drawing.Point(725, 182);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(172, 170);
            this.EditEventButton.TabIndex = 24;
            this.EditEventButton.Text = "Edytuj wydarzenie";
            this.EditEventButton.UseVisualStyleBackColor = true;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // RefreshEventsButton
            // 
            this.RefreshEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshEventsButton.Location = new System.Drawing.Point(725, 533);
            this.RefreshEventsButton.Name = "RefreshEventsButton";
            this.RefreshEventsButton.Size = new System.Drawing.Size(172, 170);
            this.RefreshEventsButton.TabIndex = 23;
            this.RefreshEventsButton.Text = "Odśwież";
            this.RefreshEventsButton.UseVisualStyleBackColor = true;
            this.RefreshEventsButton.Click += new System.EventHandler(this.RefreshEventsButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEventButton.Location = new System.Drawing.Point(725, 6);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(172, 170);
            this.AddEventButton.TabIndex = 22;
            this.AddEventButton.Text = "Dodaj wydarzenie";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // EventsCheckedListBox
            // 
            this.EventsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventsCheckedListBox.FormattingEnabled = true;
            this.EventsCheckedListBox.HorizontalScrollbar = true;
            this.EventsCheckedListBox.Location = new System.Drawing.Point(6, 6);
            this.EventsCheckedListBox.Name = "EventsCheckedListBox";
            this.EventsCheckedListBox.ScrollAlwaysVisible = true;
            this.EventsCheckedListBox.Size = new System.Drawing.Size(713, 697);
            this.EventsCheckedListBox.TabIndex = 10;
            this.EventsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EventsCheckedListBox_ItemCheck);
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.DeleteStudentButton);
            this.StudentsPage.Controls.Add(this.StudentsCheckedListBox);
            this.StudentsPage.Controls.Add(this.EditStudentButton);
            this.StudentsPage.Controls.Add(this.RefreshStudentsButton);
            this.StudentsPage.Controls.Add(this.AddStudentButton);
            this.StudentsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsPage.Location = new System.Drawing.Point(4, 38);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Size = new System.Drawing.Size(900, 714);
            this.StudentsPage.TabIndex = 2;
            this.StudentsPage.Text = "Uczniowie";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Enabled = false;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(725, 358);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(172, 169);
            this.DeleteStudentButton.TabIndex = 21;
            this.DeleteStudentButton.Text = "Usuń ucznia";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // StudentsCheckedListBox
            // 
            this.StudentsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsCheckedListBox.FormattingEnabled = true;
            this.StudentsCheckedListBox.HorizontalScrollbar = true;
            this.StudentsCheckedListBox.Location = new System.Drawing.Point(6, 6);
            this.StudentsCheckedListBox.Name = "StudentsCheckedListBox";
            this.StudentsCheckedListBox.ScrollAlwaysVisible = true;
            this.StudentsCheckedListBox.Size = new System.Drawing.Size(713, 697);
            this.StudentsCheckedListBox.TabIndex = 20;
            this.StudentsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StudentsCheckedListBox_ItemCheck);
            this.StudentsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsCheckedListBox_SelectedIndexChanged);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Enabled = false;
            this.EditStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditStudentButton.Location = new System.Drawing.Point(725, 182);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(172, 170);
            this.EditStudentButton.TabIndex = 19;
            this.EditStudentButton.Text = "Edytuj ucznia";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // RefreshStudentsButton
            // 
            this.RefreshStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshStudentsButton.Location = new System.Drawing.Point(725, 533);
            this.RefreshStudentsButton.Name = "RefreshStudentsButton";
            this.RefreshStudentsButton.Size = new System.Drawing.Size(172, 170);
            this.RefreshStudentsButton.TabIndex = 18;
            this.RefreshStudentsButton.Text = "Odśwież";
            this.RefreshStudentsButton.UseVisualStyleBackColor = true;
            this.RefreshStudentsButton.Click += new System.EventHandler(this.RefreshStudentsButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddStudentButton.Location = new System.Drawing.Point(725, 6);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(172, 170);
            this.AddStudentButton.TabIndex = 17;
            this.AddStudentButton.Text = "Dodaj ucznia";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // RankingPage
            // 
            this.RankingPage.Controls.Add(this.RefreshRankingButton);
            this.RankingPage.Controls.Add(this.CreateRankingPDFButton);
            this.RankingPage.Controls.Add(this.label3);
            this.RankingPage.Controls.Add(this.SelectSexComboBox);
            this.RankingPage.Controls.Add(this.label4);
            this.RankingPage.Controls.Add(this.NumberOfStudentsToDisplayNumericUpDown);
            this.RankingPage.Controls.Add(this.ClassRankingListBox);
            this.RankingPage.Controls.Add(this.label2);
            this.RankingPage.Controls.Add(this.IndividualRankingListBox);
            this.RankingPage.Controls.Add(this.label1);
            this.RankingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RankingPage.Location = new System.Drawing.Point(4, 38);
            this.RankingPage.Name = "RankingPage";
            this.RankingPage.Size = new System.Drawing.Size(900, 714);
            this.RankingPage.TabIndex = 3;
            this.RankingPage.Text = "Ranking";
            this.RankingPage.UseVisualStyleBackColor = true;
            // 
            // RefreshRankingButton
            // 
            this.RefreshRankingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshRankingButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshRankingButton.Name = "RefreshRankingButton";
            this.RefreshRankingButton.Size = new System.Drawing.Size(172, 40);
            this.RefreshRankingButton.TabIndex = 38;
            this.RefreshRankingButton.Text = "Odśwież";
            this.RefreshRankingButton.UseVisualStyleBackColor = true;
            this.RefreshRankingButton.Click += new System.EventHandler(this.RefreshRankingButton_Click);
            // 
            // CreateRankingPDFButton
            // 
            this.CreateRankingPDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateRankingPDFButton.Location = new System.Drawing.Point(725, 3);
            this.CreateRankingPDFButton.Name = "CreateRankingPDFButton";
            this.CreateRankingPDFButton.Size = new System.Drawing.Size(172, 40);
            this.CreateRankingPDFButton.TabIndex = 37;
            this.CreateRankingPDFButton.Text = "Utwórz PDF";
            this.CreateRankingPDFButton.UseVisualStyleBackColor = true;
            this.CreateRankingPDFButton.Click += new System.EventHandler(this.CreateRankingPDFButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(453, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Płeć:";
            // 
            // SelectSexComboBox
            // 
            this.SelectSexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectSexComboBox.FormattingEnabled = true;
            this.SelectSexComboBox.Items.AddRange(new object[] {
            "Obie",
            "Chłopcy",
            "Dziewczyny"});
            this.SelectSexComboBox.Location = new System.Drawing.Point(503, 9);
            this.SelectSexComboBox.Name = "SelectSexComboBox";
            this.SelectSexComboBox.Size = new System.Drawing.Size(216, 28);
            this.SelectSexComboBox.TabIndex = 35;
            this.SelectSexComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectSexComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(181, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Liczba osób do wyświetlenia:";
            // 
            // NumberOfStudentsToDisplayNumericUpDown
            // 
            this.NumberOfStudentsToDisplayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfStudentsToDisplayNumericUpDown.Location = new System.Drawing.Point(398, 10);
            this.NumberOfStudentsToDisplayNumericUpDown.Name = "NumberOfStudentsToDisplayNumericUpDown";
            this.NumberOfStudentsToDisplayNumericUpDown.Size = new System.Drawing.Size(49, 26);
            this.NumberOfStudentsToDisplayNumericUpDown.TabIndex = 33;
            this.NumberOfStudentsToDisplayNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOfStudentsToDisplayNumericUpDown.ValueChanged += new System.EventHandler(this.NumberOfStudentsToDisplayNumericUpDown_ValueChanged);
            // 
            // ClassRankingListBox
            // 
            this.ClassRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassRankingListBox.FormattingEnabled = true;
            this.ClassRankingListBox.ItemHeight = 20;
            this.ClassRankingListBox.Location = new System.Drawing.Point(453, 86);
            this.ClassRankingListBox.Name = "ClassRankingListBox";
            this.ClassRankingListBox.Size = new System.Drawing.Size(444, 624);
            this.ClassRankingListBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(453, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ranking klasowy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IndividualRankingListBox
            // 
            this.IndividualRankingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IndividualRankingListBox.FormattingEnabled = true;
            this.IndividualRankingListBox.ItemHeight = 20;
            this.IndividualRankingListBox.Location = new System.Drawing.Point(3, 86);
            this.IndividualRankingListBox.Name = "IndividualRankingListBox";
            this.IndividualRankingListBox.Size = new System.Drawing.Size(444, 624);
            this.IndividualRankingListBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ranking indywidualny";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.CommitConnectionStringButton);
            this.SettingsPage.Controls.Add(this.FullConnectionStringTextBox);
            this.SettingsPage.Controls.Add(this.ConfirmChangesButton);
            this.SettingsPage.Controls.Add(this.label7);
            this.SettingsPage.Controls.Add(this.label8);
            this.SettingsPage.Controls.Add(this.label9);
            this.SettingsPage.Controls.Add(this.label10);
            this.SettingsPage.Controls.Add(this.PortTextBox);
            this.SettingsPage.Controls.Add(this.UsernameTextBox);
            this.SettingsPage.Controls.Add(this.PasswordTextBox);
            this.SettingsPage.Controls.Add(this.DataSourceTextBox);
            this.SettingsPage.Controls.Add(this.label6);
            this.SettingsPage.Controls.Add(this.label5);
            this.SettingsPage.Controls.Add(this.ResetValueButton);
            this.SettingsPage.Controls.Add(this.DirectDatabaseQueryButton);
            this.SettingsPage.Controls.Add(this.DeleteValueButton);
            this.SettingsPage.Controls.Add(this.SelectValueComboBox);
            this.SettingsPage.Controls.Add(this.EditValueButton);
            this.SettingsPage.Controls.Add(this.AddValueButton);
            this.SettingsPage.Controls.Add(this.InsertValueTextBox);
            this.SettingsPage.Controls.Add(this.SelectKeyComboBox);
            this.SettingsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsPage.Location = new System.Drawing.Point(4, 38);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(900, 714);
            this.SettingsPage.TabIndex = 4;
            this.SettingsPage.Text = "Ustawienia";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // CommitConnectionStringButton
            // 
            this.CommitConnectionStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommitConnectionStringButton.Location = new System.Drawing.Point(3, 656);
            this.CommitConnectionStringButton.Name = "CommitConnectionStringButton";
            this.CommitConnectionStringButton.Size = new System.Drawing.Size(894, 55);
            this.CommitConnectionStringButton.TabIndex = 30;
            this.CommitConnectionStringButton.Text = "Zatwierdź pełnego connection stringa";
            this.CommitConnectionStringButton.UseVisualStyleBackColor = true;
            this.CommitConnectionStringButton.Click += new System.EventHandler(this.CommitConnectionStringButton_Click);
            // 
            // FullConnectionStringTextBox
            // 
            this.FullConnectionStringTextBox.Location = new System.Drawing.Point(3, 463);
            this.FullConnectionStringTextBox.Multiline = false;
            this.FullConnectionStringTextBox.Name = "FullConnectionStringTextBox";
            this.FullConnectionStringTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.FullConnectionStringTextBox.Size = new System.Drawing.Size(894, 187);
            this.FullConnectionStringTextBox.TabIndex = 29;
            this.FullConnectionStringTextBox.Text = "";
            // 
            // ConfirmChangesButton
            // 
            this.ConfirmChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmChangesButton.Location = new System.Drawing.Point(3, 402);
            this.ConfirmChangesButton.Name = "ConfirmChangesButton";
            this.ConfirmChangesButton.Size = new System.Drawing.Size(894, 55);
            this.ConfirmChangesButton.TabIndex = 28;
            this.ConfirmChangesButton.Text = "Zatwierdź";
            this.ConfirmChangesButton.UseVisualStyleBackColor = true;
            this.ConfirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(99, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hasło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(7, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nazwa użytkownika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(112, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(39, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Adres serwera";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortTextBox.Location = new System.Drawing.Point(156, 306);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(741, 26);
            this.PortTextBox.TabIndex = 23;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameTextBox.Location = new System.Drawing.Point(156, 338);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(741, 26);
            this.UsernameTextBox.TabIndex = 22;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(156, 370);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(741, 26);
            this.PasswordTextBox.TabIndex = 21;
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataSourceTextBox.Location = new System.Drawing.Point(156, 274);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(741, 26);
            this.DataSourceTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Square721 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(894, 49);
            this.label6.TabIndex = 19;
            this.label6.Text = "UWAGA!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(894, 80);
            this.label5.TabIndex = 18;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetValueButton
            // 
            this.ResetValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetValueButton.Location = new System.Drawing.Point(725, 240);
            this.ResetValueButton.Name = "ResetValueButton";
            this.ResetValueButton.Size = new System.Drawing.Size(172, 28);
            this.ResetValueButton.TabIndex = 17;
            this.ResetValueButton.Text = "Resetuj";
            this.ResetValueButton.UseVisualStyleBackColor = true;
            this.ResetValueButton.Click += new System.EventHandler(this.ResetValueButton_Click);
            // 
            // DirectDatabaseQueryButton
            // 
            this.DirectDatabaseQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DirectDatabaseQueryButton.Location = new System.Drawing.Point(3, 241);
            this.DirectDatabaseQueryButton.Name = "DirectDatabaseQueryButton";
            this.DirectDatabaseQueryButton.Size = new System.Drawing.Size(716, 28);
            this.DirectDatabaseQueryButton.TabIndex = 16;
            this.DirectDatabaseQueryButton.Text = "Bezpośrednie zapytanie do bazy (DEV)";
            this.DirectDatabaseQueryButton.UseVisualStyleBackColor = true;
            this.DirectDatabaseQueryButton.Click += new System.EventHandler(this.DirectDatabaseQueryButton_Click);
            // 
            // DeleteValueButton
            // 
            this.DeleteValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteValueButton.Location = new System.Drawing.Point(725, 206);
            this.DeleteValueButton.Name = "DeleteValueButton";
            this.DeleteValueButton.Size = new System.Drawing.Size(172, 28);
            this.DeleteValueButton.TabIndex = 15;
            this.DeleteValueButton.Text = "Usuń";
            this.DeleteValueButton.UseVisualStyleBackColor = true;
            this.DeleteValueButton.Click += new System.EventHandler(this.DeleteValueButton_Click);
            // 
            // SelectValueComboBox
            // 
            this.SelectValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectValueComboBox.FormattingEnabled = true;
            this.SelectValueComboBox.Location = new System.Drawing.Point(3, 172);
            this.SelectValueComboBox.Name = "SelectValueComboBox";
            this.SelectValueComboBox.Size = new System.Drawing.Size(716, 28);
            this.SelectValueComboBox.TabIndex = 14;
            this.SelectValueComboBox.Text = "Wybierz wartość";
            // 
            // EditValueButton
            // 
            this.EditValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditValueButton.Location = new System.Drawing.Point(725, 171);
            this.EditValueButton.Name = "EditValueButton";
            this.EditValueButton.Size = new System.Drawing.Size(172, 28);
            this.EditValueButton.TabIndex = 13;
            this.EditValueButton.Text = "Edytuj";
            this.EditValueButton.UseVisualStyleBackColor = true;
            this.EditValueButton.Click += new System.EventHandler(this.EditValueButton_Click);
            // 
            // AddValueButton
            // 
            this.AddValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddValueButton.Location = new System.Drawing.Point(725, 137);
            this.AddValueButton.Name = "AddValueButton";
            this.AddValueButton.Size = new System.Drawing.Size(172, 28);
            this.AddValueButton.TabIndex = 12;
            this.AddValueButton.Text = "Dodaj";
            this.AddValueButton.UseVisualStyleBackColor = true;
            this.AddValueButton.Click += new System.EventHandler(this.AddValueButton_Click);
            // 
            // InsertValueTextBox
            // 
            this.InsertValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertValueTextBox.Location = new System.Drawing.Point(3, 206);
            this.InsertValueTextBox.Name = "InsertValueTextBox";
            this.InsertValueTextBox.Size = new System.Drawing.Size(716, 26);
            this.InsertValueTextBox.TabIndex = 11;
            this.InsertValueTextBox.Text = "Wprowadź wartość";
            // 
            // SelectKeyComboBox
            // 
            this.SelectKeyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectKeyComboBox.FormattingEnabled = true;
            this.SelectKeyComboBox.Location = new System.Drawing.Point(3, 138);
            this.SelectKeyComboBox.Name = "SelectKeyComboBox";
            this.SelectKeyComboBox.Size = new System.Drawing.Size(716, 28);
            this.SelectKeyComboBox.TabIndex = 10;
            this.SelectKeyComboBox.Text = "Wybierz klucz";
            this.SelectKeyComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectKeyComboBox_SelectedIndexChanged);
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 794);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewMainForm";
            this.Text = "Proton";
            this.MainTabControl.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EventPage.ResumeLayout(false);
            this.StudentsPage.ResumeLayout(false);
            this.RankingPage.ResumeLayout(false);
            this.RankingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStudentsToDisplayNumericUpDown)).EndInit();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage EventPage;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.TabPage RankingPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.CheckedListBox EventsCheckedListBox;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.CheckedListBox StudentsCheckedListBox;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button RefreshStudentsButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox IndividualRankingListBox;
        private System.Windows.Forms.ListBox ClassRankingListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectSexComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumberOfStudentsToDisplayNumericUpDown;
        private System.Windows.Forms.Button CreateRankingPDFButton;
        private System.Windows.Forms.Button RefreshRankingButton;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.Button RefreshEventsButton;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button ResetValueButton;
        private System.Windows.Forms.Button DirectDatabaseQueryButton;
        private System.Windows.Forms.Button DeleteValueButton;
        private System.Windows.Forms.ComboBox SelectValueComboBox;
        private System.Windows.Forms.Button EditValueButton;
        private System.Windows.Forms.Button AddValueButton;
        private System.Windows.Forms.TextBox InsertValueTextBox;
        private System.Windows.Forms.ComboBox SelectKeyComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CommitConnectionStringButton;
        private System.Windows.Forms.RichTextBox FullConnectionStringTextBox;
        private System.Windows.Forms.Button ConfirmChangesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label NewsLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button SubmitIssueButton;
    }
}