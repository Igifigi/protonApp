
namespace protonApp.GUI
{
    partial class AddPointsManually
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
            this.addedStudentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.studentsToAddCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addEventButton = new System.Windows.Forms.Button();
            this.arePointsTransitiveCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addedStudentsCheckedListBox
            // 
            this.addedStudentsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addedStudentsCheckedListBox.FormattingEnabled = true;
            this.addedStudentsCheckedListBox.Location = new System.Drawing.Point(318, 174);
            this.addedStudentsCheckedListBox.Name = "addedStudentsCheckedListBox";
            this.addedStudentsCheckedListBox.Size = new System.Drawing.Size(300, 424);
            this.addedStudentsCheckedListBox.TabIndex = 7;
            this.addedStudentsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.addedStudentsCheckedListBox_ItemCheck);
            // 
            // studentsToAddCheckedListBox
            // 
            this.studentsToAddCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentsToAddCheckedListBox.FormattingEnabled = true;
            this.studentsToAddCheckedListBox.Location = new System.Drawing.Point(12, 174);
            this.studentsToAddCheckedListBox.Name = "studentsToAddCheckedListBox";
            this.studentsToAddCheckedListBox.Size = new System.Drawing.Size(300, 424);
            this.studentsToAddCheckedListBox.TabIndex = 5;
            this.studentsToAddCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.studentsToAddCheckedListBox_ItemCheck);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Enabled = false;
            this.deleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteStudentButton.Location = new System.Drawing.Point(318, 140);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(300, 28);
            this.deleteStudentButton.TabIndex = 6;
            this.deleteStudentButton.Text = "Usuń ucznia";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStudentButton.Location = new System.Drawing.Point(12, 140);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(300, 28);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Dodaj ucznia";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameTextBox.Location = new System.Drawing.Point(90, 76);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(528, 26);
            this.studentNameTextBox.TabIndex = 2;
            this.studentNameTextBox.Text = "Wprowadź nazwisko";
            this.studentNameTextBox.Click += new System.EventHandler(this.studentNameTextBox_Click);
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.studentNameTextBox_TextChanged);
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(606, 26);
            this.eventNameTextBox.TabIndex = 0;
            this.eventNameTextBox.Text = "Nazwa wydarzenia";
            this.eventNameTextBox.Click += new System.EventHandler(this.eventNameTextBox_Click);
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventDateTimePicker.Location = new System.Drawing.Point(12, 44);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(606, 26);
            this.eventDateTimePicker.TabIndex = 1;
            this.eventDateTimePicker.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // studentPointsNumericUpDown
            // 
            this.studentPointsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentPointsNumericUpDown.Location = new System.Drawing.Point(120, 108);
            this.studentPointsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.studentPointsNumericUpDown.Name = "studentPointsNumericUpDown";
            this.studentPointsNumericUpDown.Size = new System.Drawing.Size(498, 26);
            this.studentPointsNumericUpDown.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(8, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ilość punktów";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nazwisko";
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(12, 639);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(606, 40);
            this.addEventButton.TabIndex = 9;
            this.addEventButton.Text = "DODAJ WYDARZENIE";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // arePointsTransitiveCheckBox
            // 
            this.arePointsTransitiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arePointsTransitiveCheckBox.Location = new System.Drawing.Point(12, 604);
            this.arePointsTransitiveCheckBox.Name = "arePointsTransitiveCheckBox";
            this.arePointsTransitiveCheckBox.Size = new System.Drawing.Size(606, 29);
            this.arePointsTransitiveCheckBox.TabIndex = 8;
            this.arePointsTransitiveCheckBox.Text = "Czy punkty przechodzą na klasę?";
            this.arePointsTransitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddPointsManually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 688);
            this.Controls.Add(this.arePointsTransitiveCheckBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentPointsNumericUpDown);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventDateTimePicker);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.addedStudentsCheckedListBox);
            this.Controls.Add(this.studentsToAddCheckedListBox);
            this.Name = "AddPointsManually";
            this.Text = "AddPointsManually";
            ((System.ComponentModel.ISupportInitialize)(this.studentPointsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox addedStudentsCheckedListBox;
        private System.Windows.Forms.CheckedListBox studentsToAddCheckedListBox;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.NumericUpDown studentPointsNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.CheckBox arePointsTransitiveCheckBox;
    }
}