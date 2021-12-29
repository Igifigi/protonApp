namespace protonApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.eventsButton = new System.Windows.Forms.Button();
            this.studnetsButton = new System.Windows.Forms.Button();
            this.rankingButton = new System.Windows.Forms.Button();
            this.directQueryButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventsButton
            // 
            this.eventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventsButton.Location = new System.Drawing.Point(204, 322);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(186, 116);
            this.eventsButton.TabIndex = 1;
            this.eventsButton.Text = "Wydarzenia";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // studnetsButton
            // 
            this.studnetsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studnetsButton.Location = new System.Drawing.Point(396, 322);
            this.studnetsButton.Name = "studnetsButton";
            this.studnetsButton.Size = new System.Drawing.Size(186, 116);
            this.studnetsButton.TabIndex = 4;
            this.studnetsButton.Text = "Uczniowie\r\n";
            this.studnetsButton.UseVisualStyleBackColor = true;
            this.studnetsButton.Click += new System.EventHandler(this.studnetsButton_Click);
            // 
            // rankingButton
            // 
            this.rankingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rankingButton.Location = new System.Drawing.Point(12, 322);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(186, 116);
            this.rankingButton.TabIndex = 6;
            this.rankingButton.Text = "Ranking";
            this.rankingButton.UseVisualStyleBackColor = true;
            this.rankingButton.Click += new System.EventHandler(this.rankingButton_Click);
            // 
            // directQueryButton
            // 
            this.directQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directQueryButton.Location = new System.Drawing.Point(588, 382);
            this.directQueryButton.Name = "directQueryButton";
            this.directQueryButton.Size = new System.Drawing.Size(186, 56);
            this.directQueryButton.TabIndex = 8;
            this.directQueryButton.Text = "Bezpośrenie zapytanie do bazy";
            this.directQueryButton.UseVisualStyleBackColor = true;
            this.directQueryButton.Click += new System.EventHandler(this.DirectQueryButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.Location = new System.Drawing.Point(588, 322);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(186, 54);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.directQueryButton);
            this.Controls.Add(this.rankingButton);
            this.Controls.Add(this.studnetsButton);
            this.Controls.Add(this.eventsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Proton App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button studnetsButton;
        private System.Windows.Forms.Button rankingButton;
        private System.Windows.Forms.Button directQueryButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

