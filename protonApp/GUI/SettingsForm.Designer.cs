namespace protonApp.GUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.selectKeyComboBox = new System.Windows.Forms.ComboBox();
            this.insertValueTextBox = new System.Windows.Forms.TextBox();
            this.addValueButton = new System.Windows.Forms.Button();
            this.editValueButton = new System.Windows.Forms.Button();
            this.selectValueComboBox = new System.Windows.Forms.ComboBox();
            this.deleteValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectKeyComboBox
            // 
            this.selectKeyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectKeyComboBox.FormattingEnabled = true;
            this.selectKeyComboBox.Location = new System.Drawing.Point(13, 13);
            this.selectKeyComboBox.Name = "selectKeyComboBox";
            this.selectKeyComboBox.Size = new System.Drawing.Size(251, 28);
            this.selectKeyComboBox.TabIndex = 0;
            this.selectKeyComboBox.Text = "Wybierz klucz";
            this.selectKeyComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectKeyComboBox_SelectedIndexChanged);
            // 
            // insertValueTextBox
            // 
            this.insertValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertValueTextBox.Location = new System.Drawing.Point(12, 81);
            this.insertValueTextBox.Name = "insertValueTextBox";
            this.insertValueTextBox.Size = new System.Drawing.Size(252, 26);
            this.insertValueTextBox.TabIndex = 1;
            this.insertValueTextBox.Text = "Wprowadź wartość";
            // 
            // addValueButton
            // 
            this.addValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addValueButton.Location = new System.Drawing.Point(270, 13);
            this.addValueButton.Name = "addValueButton";
            this.addValueButton.Size = new System.Drawing.Size(105, 28);
            this.addValueButton.TabIndex = 2;
            this.addValueButton.Text = "Dodaj";
            this.addValueButton.UseVisualStyleBackColor = true;
            this.addValueButton.Click += new System.EventHandler(this.AddValueButton_Click);
            // 
            // editValueButton
            // 
            this.editValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editValueButton.Location = new System.Drawing.Point(270, 47);
            this.editValueButton.Name = "editValueButton";
            this.editValueButton.Size = new System.Drawing.Size(106, 28);
            this.editValueButton.TabIndex = 3;
            this.editValueButton.Text = "Edytuj";
            this.editValueButton.UseVisualStyleBackColor = true;
            this.editValueButton.Click += new System.EventHandler(this.EditValueButton_Click);
            // 
            // selectValueComboBox
            // 
            this.selectValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectValueComboBox.FormattingEnabled = true;
            this.selectValueComboBox.Location = new System.Drawing.Point(12, 47);
            this.selectValueComboBox.Name = "selectValueComboBox";
            this.selectValueComboBox.Size = new System.Drawing.Size(252, 28);
            this.selectValueComboBox.TabIndex = 4;
            this.selectValueComboBox.Text = "Wybierz wartość";
            // 
            // deleteValueButton
            // 
            this.deleteValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteValueButton.Location = new System.Drawing.Point(270, 79);
            this.deleteValueButton.Name = "deleteValueButton";
            this.deleteValueButton.Size = new System.Drawing.Size(105, 28);
            this.deleteValueButton.TabIndex = 5;
            this.deleteValueButton.Text = "Usuń";
            this.deleteValueButton.UseVisualStyleBackColor = true;
            this.deleteValueButton.Click += new System.EventHandler(this.DeleteValueButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 119);
            this.Controls.Add(this.deleteValueButton);
            this.Controls.Add(this.selectValueComboBox);
            this.Controls.Add(this.editValueButton);
            this.Controls.Add(this.addValueButton);
            this.Controls.Add(this.insertValueTextBox);
            this.Controls.Add(this.selectKeyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectKeyComboBox;
        private System.Windows.Forms.TextBox insertValueTextBox;
        private System.Windows.Forms.Button addValueButton;
        private System.Windows.Forms.Button editValueButton;
        private System.Windows.Forms.ComboBox selectValueComboBox;
        private System.Windows.Forms.Button deleteValueButton;
    }
}