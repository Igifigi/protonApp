﻿namespace protonApp.GUI
{
    partial class StudentEditForm
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
            this.editStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.womenRadioButton = new System.Windows.Forms.RadioButton();
            this.menRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(15, 212);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(277, 93);
            this.editStudent.TabIndex = 19;
            this.editStudent.Text = "Edytuj Ucznia";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Klasa";
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Location = new System.Drawing.Point(71, 89);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(221, 21);
            this.selectClassComboBox.TabIndex = 17;
            this.selectClassComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // womenRadioButton
            // 
            this.womenRadioButton.AutoSize = true;
            this.womenRadioButton.Location = new System.Drawing.Point(155, 65);
            this.womenRadioButton.Name = "womenRadioButton";
            this.womenRadioButton.Size = new System.Drawing.Size(61, 17);
            this.womenRadioButton.TabIndex = 16;
            this.womenRadioButton.TabStop = true;
            this.womenRadioButton.Text = "Kobieta";
            this.womenRadioButton.UseVisualStyleBackColor = true;
            this.womenRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // menRadioButton
            // 
            this.menRadioButton.AutoSize = true;
            this.menRadioButton.Location = new System.Drawing.Point(71, 65);
            this.menRadioButton.Name = "menRadioButton";
            this.menRadioButton.Size = new System.Drawing.Size(78, 17);
            this.menRadioButton.TabIndex = 15;
            this.menRadioButton.TabStop = true;
            this.menRadioButton.Text = "Mężczyzna";
            this.menRadioButton.UseVisualStyleBackColor = true;
            this.menRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Płeć";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwisko";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imię";
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 317);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectClassComboBox);
            this.Controls.Add(this.womenRadioButton);
            this.Controls.Add(this.menRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "StudentEditForm";
            this.Text = "44";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private System.Windows.Forms.RadioButton womenRadioButton;
        private System.Windows.Forms.RadioButton menRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}