namespace protonApp.GUI
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.addEventButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.eventsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(12, 15);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(212, 35);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Dodaj wydarzenie";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(677, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 35);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editEventButton.Location = new System.Drawing.Point(230, 15);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(212, 35);
            this.editEventButton.TabIndex = 3;
            this.editEventButton.Text = "Edytuj wydarzenie";
            this.editEventButton.UseVisualStyleBackColor = true;
            // 
            // eventsTextBox
            // 
            this.eventsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.eventsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventsTextBox.Location = new System.Drawing.Point(13, 57);
            this.eventsTextBox.Multiline = true;
            this.eventsTextBox.Name = "eventsTextBox";
            this.eventsTextBox.ReadOnly = true;
            this.eventsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.eventsTextBox.Size = new System.Drawing.Size(429, 381);
            this.eventsTextBox.TabIndex = 4;
            this.eventsTextBox.TabStop = false;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventsTextBox);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addEventButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsForm";
            this.Text = "eventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.TextBox eventsTextBox;
    }
}