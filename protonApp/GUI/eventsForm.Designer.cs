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
            this.eventsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEventButton.Location = new System.Drawing.Point(459, 12);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(165, 170);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Dodaj wydarzenie";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(459, 540);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(165, 169);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Enabled = false;
            this.editEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editEventButton.Location = new System.Drawing.Point(459, 188);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(165, 169);
            this.editEventButton.TabIndex = 3;
            this.editEventButton.Text = "Edytuj wydarzenie";
            this.editEventButton.UseVisualStyleBackColor = true;
            this.editEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // eventsCheckedListBox
            // 
            this.eventsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventsCheckedListBox.FormattingEnabled = true;
            this.eventsCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.eventsCheckedListBox.Name = "eventsCheckedListBox";
            this.eventsCheckedListBox.Size = new System.Drawing.Size(441, 697);
            this.eventsCheckedListBox.TabIndex = 5;
            this.eventsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EventsCheckedListBox_ItemCheck);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Enabled = false;
            this.deleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteEventButton.Location = new System.Drawing.Point(459, 363);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(165, 171);
            this.deleteEventButton.TabIndex = 6;
            this.deleteEventButton.Text = "Usuń wydarzenie";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 715);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.eventsCheckedListBox);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addEventButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EventsForm";
            this.Text = "Wydarzenia";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.CheckedListBox eventsCheckedListBox;
        private System.Windows.Forms.Button deleteEventButton;
    }
}