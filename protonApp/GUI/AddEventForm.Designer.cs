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
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sportDisciplineComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventDateTimePicker.Location = new System.Drawing.Point(12, 80);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(391, 26);
            this.eventDateTimePicker.TabIndex = 3;
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(391, 28);
            this.eventTypeComboBox.TabIndex = 4;
            this.eventTypeComboBox.Text = "Typ wydarzenia";
            // 
            // sportDisciplineComboBox
            // 
            this.sportDisciplineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sportDisciplineComboBox.FormattingEnabled = true;
            this.sportDisciplineComboBox.Location = new System.Drawing.Point(12, 46);
            this.sportDisciplineComboBox.Name = "sportDisciplineComboBox";
            this.sportDisciplineComboBox.Size = new System.Drawing.Size(391, 28);
            this.sportDisciplineComboBox.TabIndex = 5;
            this.sportDisciplineComboBox.Text = "Dyscyplina";
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.sportDisciplineComboBox);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(this.eventDateTimePicker);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.ComboBox sportDisciplineComboBox;
    }
}