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
            this.studentNameTextBox.Location = new System.Drawing.Point(409, 44);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.studentNameTextBox.TabIndex = 6;
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.StudentNameTextBox_TextChanged);
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(409, 78);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(379, 28);
            this.studentNameComboBox.TabIndex = 7;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(776, 26);
            this.eventNameTextBox.TabIndex = 8;
            this.eventNameTextBox.Text = "Nazwa wydarzenia";
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.EventNameTextBox_TextChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(12, 269);
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
            this.resultLabel.Location = new System.Drawing.Point(12, 141);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(391, 125);
            this.resultLabel.TabIndex = 10;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}