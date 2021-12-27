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
            this.addEventButton = new System.Windows.Forms.Button();
            this.displayEventsLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
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
            // displayEventsLabel
            // 
            this.displayEventsLabel.AutoSize = true;
            this.displayEventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayEventsLabel.Location = new System.Drawing.Point(12, 53);
            this.displayEventsLabel.Name = "displayEventsLabel";
            this.displayEventsLabel.Size = new System.Drawing.Size(51, 20);
            this.displayEventsLabel.TabIndex = 1;
            this.displayEventsLabel.Text = "label1";
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
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.displayEventsLabel);
            this.Controls.Add(this.addEventButton);
            this.Name = "EventsForm";
            this.Text = "eventsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label displayEventsLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button editEventButton;
    }
}