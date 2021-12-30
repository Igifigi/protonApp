namespace protonApp.GUI
{
    partial class StudentsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsListForm));
            this.StudentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsCheckedListBox
            // 
            this.StudentsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsCheckedListBox.FormattingEnabled = true;
            this.StudentsCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.StudentsCheckedListBox.Name = "StudentsCheckedListBox";
            this.StudentsCheckedListBox.Size = new System.Drawing.Size(388, 259);
            this.StudentsCheckedListBox.TabIndex = 0;
            this.StudentsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStudentButton.Location = new System.Drawing.Point(407, 12);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(381, 85);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "DODAJ UCZNIA";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // editStudentButton
            // 
            this.editStudentButton.Enabled = false;
            this.editStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editStudentButton.Location = new System.Drawing.Point(407, 103);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(381, 85);
            this.editStudentButton.TabIndex = 2;
            this.editStudentButton.Text = "EDYTUJ UCZNIA";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Enabled = false;
            this.removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeStudentButton.Location = new System.Drawing.Point(407, 194);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(381, 77);
            this.removeStudentButton.TabIndex = 3;
            this.removeStudentButton.Text = "USUŃ UCZNIA";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(12, 277);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(776, 55);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "ODŚWIEŻ";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // StudentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.StudentsCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentsListForm";
            this.Text = "Uczniowie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox StudentsCheckedListBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button refreshButton;
    }
}