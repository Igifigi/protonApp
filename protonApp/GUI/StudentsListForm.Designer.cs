﻿namespace protonApp.GUI
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.editStudent = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(388, 259);
            this.checkedListBox1.TabIndex = 0;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(407, 12);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(381, 85);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Dodaj Ucznia";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(407, 103);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(381, 85);
            this.editStudent.TabIndex = 2;
            this.editStudent.Text = "Edytuj Ucznia";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.Location = new System.Drawing.Point(407, 194);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(381, 85);
            this.removeStudent.TabIndex = 3;
            this.removeStudent.Text = "Usuń Ucznia";
            this.removeStudent.UseVisualStyleBackColor = true;
            // 
            // StudentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "StudentsListForm";
            this.Text = "StudentsListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Button removeStudent;
    }
}