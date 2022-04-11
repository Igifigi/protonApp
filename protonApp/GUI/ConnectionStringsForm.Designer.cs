namespace protonApp.GUI
{
    partial class ConnectionStringsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionStringsForm));
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commitChangesButton = new System.Windows.Forms.Button();
            this.fullConnectionStringTextBox = new System.Windows.Forms.RichTextBox();
            this.commitChangesButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataSourceTextBox.Location = new System.Drawing.Point(161, 6);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(257, 26);
            this.dataSourceTextBox.TabIndex = 0;
            this.dataSourceTextBox.TextChanged += new System.EventHandler(this.DataSourceTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(161, 102);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(257, 26);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTextBox.Location = new System.Drawing.Point(161, 70);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(257, 26);
            this.usernameTextBox.TabIndex = 2;
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portTextBox.Location = new System.Drawing.Point(161, 38);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(257, 26);
            this.portTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adres serwera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(117, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwa użytkownika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(104, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło";
            // 
            // commitChangesButton
            // 
            this.commitChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commitChangesButton.Location = new System.Drawing.Point(12, 134);
            this.commitChangesButton.Name = "commitChangesButton";
            this.commitChangesButton.Size = new System.Drawing.Size(406, 55);
            this.commitChangesButton.TabIndex = 8;
            this.commitChangesButton.Text = "Zatwierdź";
            this.commitChangesButton.UseVisualStyleBackColor = true;
            this.commitChangesButton.Click += new System.EventHandler(this.CommitChangesButton_Click);
            // 
            // fullConnectionStringTextBox
            // 
            this.fullConnectionStringTextBox.Location = new System.Drawing.Point(12, 195);
            this.fullConnectionStringTextBox.Multiline = false;
            this.fullConnectionStringTextBox.Name = "fullConnectionStringTextBox";
            this.fullConnectionStringTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.fullConnectionStringTextBox.Size = new System.Drawing.Size(406, 98);
            this.fullConnectionStringTextBox.TabIndex = 10;
            this.fullConnectionStringTextBox.Text = "";
            // 
            // commitChangesButton2
            // 
            this.commitChangesButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commitChangesButton2.Location = new System.Drawing.Point(12, 299);
            this.commitChangesButton2.Name = "commitChangesButton2";
            this.commitChangesButton2.Size = new System.Drawing.Size(406, 55);
            this.commitChangesButton2.TabIndex = 11;
            this.commitChangesButton2.Text = "Zatwierdź pełnego connection stringa";
            this.commitChangesButton2.UseVisualStyleBackColor = true;
            this.commitChangesButton2.Click += new System.EventHandler(this.commitChangesButton2_Click);
            // 
            // ConnectionStringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 366);
            this.Controls.Add(this.commitChangesButton2);
            this.Controls.Add(this.fullConnectionStringTextBox);
            this.Controls.Add(this.commitChangesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.dataSourceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConnectionStringsForm";
            this.Text = "ConnectionStringsForm";
            this.Load += new System.EventHandler(this.ConnectionStringsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button commitChangesButton;
        private System.Windows.Forms.RichTextBox fullConnectionStringTextBox;
        private System.Windows.Forms.Button commitChangesButton2;
    }
}