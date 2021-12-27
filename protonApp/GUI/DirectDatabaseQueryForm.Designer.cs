namespace protonApp.GUI
{
    partial class DirectDatabaseQueryForm
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
            this.queryTextbox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.chooseQueryMethodComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // queryTextbox
            // 
            this.queryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryTextbox.Location = new System.Drawing.Point(12, 51);
            this.queryTextbox.Multiline = true;
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(776, 169);
            this.queryTextbox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goButton.Location = new System.Drawing.Point(12, 226);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(776, 65);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "ZATWIERDŹ";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // chooseQueryMethodComboBox
            // 
            this.chooseQueryMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseQueryMethodComboBox.FormattingEnabled = true;
            this.chooseQueryMethodComboBox.Location = new System.Drawing.Point(12, 12);
            this.chooseQueryMethodComboBox.Name = "chooseQueryMethodComboBox";
            this.chooseQueryMethodComboBox.Size = new System.Drawing.Size(776, 33);
            this.chooseQueryMethodComboBox.TabIndex = 2;
            this.chooseQueryMethodComboBox.Text = "Wybierz typ zapytania";
            // 
            // DirectDatabaseQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.chooseQueryMethodComboBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.queryTextbox);
            this.Name = "DirectDatabaseQueryForm";
            this.Text = "DirectDatabaseQuery";
            this.Load += new System.EventHandler(this.DirectDatabaseQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryTextbox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox chooseQueryMethodComboBox;
    }
}