
namespace protonApp.GUI
{
    partial class DeveloperToolsForm
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
            this.saveAllEventsIntoJSONFileCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // saveAllEventsIntoJSONFileCheckBox
            // 
            this.saveAllEventsIntoJSONFileCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveAllEventsIntoJSONFileCheckBox.Location = new System.Drawing.Point(12, 12);
            this.saveAllEventsIntoJSONFileCheckBox.Name = "saveAllEventsIntoJSONFileCheckBox";
            this.saveAllEventsIntoJSONFileCheckBox.Size = new System.Drawing.Size(389, 34);
            this.saveAllEventsIntoJSONFileCheckBox.TabIndex = 0;
            this.saveAllEventsIntoJSONFileCheckBox.Text = "Zapisuj wydarzenia do pliku JSON";
            this.saveAllEventsIntoJSONFileCheckBox.UseVisualStyleBackColor = true;
            this.saveAllEventsIntoJSONFileCheckBox.CheckedChanged += new System.EventHandler(this.saveAllEventsIntoJSONFileCheckBox_CheckedChanged);
            // 
            // DeveloperToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveAllEventsIntoJSONFileCheckBox);
            this.Name = "DeveloperToolsForm";
            this.Text = "DeveloperToolsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox saveAllEventsIntoJSONFileCheckBox;
    }
}