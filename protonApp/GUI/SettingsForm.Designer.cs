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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.selectKeyComboBox = new System.Windows.Forms.ComboBox();
            this.insertValueTextBox = new System.Windows.Forms.TextBox();
            this.addValueButton = new System.Windows.Forms.Button();
            this.editValueButton = new System.Windows.Forms.Button();
            this.selectValueComboBox = new System.Windows.Forms.ComboBox();
            this.deleteValueButton = new System.Windows.Forms.Button();
            this.directDatabaseQueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetValueButton = new System.Windows.Forms.Button();
            this.resetValueButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // selectKeyComboBox
            // 
            this.selectKeyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectKeyComboBox.FormattingEnabled = true;
            this.selectKeyComboBox.Location = new System.Drawing.Point(12, 100);
            this.selectKeyComboBox.Name = "selectKeyComboBox";
            this.selectKeyComboBox.Size = new System.Drawing.Size(251, 28);
            this.selectKeyComboBox.TabIndex = 0;
            this.selectKeyComboBox.Text = "Wybierz klucz";
            this.selectKeyComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectKeyComboBox_SelectedIndexChanged);
            // 
            // insertValueTextBox
            // 
            this.insertValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertValueTextBox.Location = new System.Drawing.Point(11, 168);
            this.insertValueTextBox.Name = "insertValueTextBox";
            this.insertValueTextBox.Size = new System.Drawing.Size(252, 26);
            this.insertValueTextBox.TabIndex = 1;
            this.insertValueTextBox.Text = "Wprowadź wartość";
            // 
            // addValueButton
            // 
            this.addValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addValueButton.Location = new System.Drawing.Point(269, 100);
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
            this.editValueButton.Location = new System.Drawing.Point(269, 134);
            this.editValueButton.Name = "editValueButton";
            this.editValueButton.Size = new System.Drawing.Size(105, 28);
            this.editValueButton.TabIndex = 3;
            this.editValueButton.Text = "Edytuj";
            this.editValueButton.UseVisualStyleBackColor = true;
            this.editValueButton.Click += new System.EventHandler(this.EditValueButton_Click);
            // 
            // selectValueComboBox
            // 
            this.selectValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectValueComboBox.FormattingEnabled = true;
            this.selectValueComboBox.Location = new System.Drawing.Point(11, 134);
            this.selectValueComboBox.Name = "selectValueComboBox";
            this.selectValueComboBox.Size = new System.Drawing.Size(252, 28);
            this.selectValueComboBox.TabIndex = 4;
            this.selectValueComboBox.Text = "Wybierz wartość";
            // 
            // deleteValueButton
            // 
            this.deleteValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteValueButton.Location = new System.Drawing.Point(269, 166);
            this.deleteValueButton.Name = "deleteValueButton";
            this.deleteValueButton.Size = new System.Drawing.Size(105, 28);
            this.deleteValueButton.TabIndex = 5;
            this.deleteValueButton.Text = "Usuń";
            this.deleteValueButton.UseVisualStyleBackColor = true;
            this.deleteValueButton.Click += new System.EventHandler(this.DeleteValueButton_Click);
            // 
            // directDatabaseQueryButton
            // 
            this.directDatabaseQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directDatabaseQueryButton.Location = new System.Drawing.Point(12, 200);
            this.directDatabaseQueryButton.Name = "directDatabaseQueryButton";
            this.directDatabaseQueryButton.Size = new System.Drawing.Size(252, 28);
            this.directDatabaseQueryButton.TabIndex = 6;
            this.directDatabaseQueryButton.Text = "Bezpośrednie zapytanie do bazy";
            this.directDatabaseQueryButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Square721 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "UWAGA!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 53);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nigdy nie edytuj kluczy, których przeznaczenia nie znasz!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetValueButton
            // 
            this.resetValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetValueButton.Location = new System.Drawing.Point(269, 200);
            this.resetValueButton.Name = "resetValueButton";
            this.resetValueButton.Size = new System.Drawing.Size(105, 28);
            this.resetValueButton.TabIndex = 9;
            this.resetValueButton.Text = "Resetuj";
            this.resetValueButtonToolTip.SetToolTip(this.resetValueButton, "Przywróć do ustawień domyślnych");
            this.resetValueButton.UseVisualStyleBackColor = true;
            this.resetValueButton.Click += new System.EventHandler(this.ResetValueButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 240);
            this.Controls.Add(this.resetValueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directDatabaseQueryButton);
            this.Controls.Add(this.deleteValueButton);
            this.Controls.Add(this.selectValueComboBox);
            this.Controls.Add(this.editValueButton);
            this.Controls.Add(this.addValueButton);
            this.Controls.Add(this.insertValueTextBox);
            this.Controls.Add(this.selectKeyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
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
        private System.Windows.Forms.Button directDatabaseQueryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetValueButton;
        private System.Windows.Forms.ToolTip resetValueButtonToolTip;
    }
}