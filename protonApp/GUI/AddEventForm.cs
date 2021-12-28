using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using protonApp.Data;
using protonApp.Model;
using protonApp.Logic;

namespace protonApp.GUI
{
    public partial class AddEventForm : Form
    {
        DatabaseDownloader databaseDownloader = new DatabaseDownloader();
        //TechnicalFunctions technicalFunctions = new TechnicalFunctions();
        public AddEventForm()
        {
            InitializeComponent();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            eventTypeComboBox.Items.AddRange(TechnicalFunctions.getSetting("Typ wydarzeń").Split(new char[] { ';' }));
            //sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting("Dyscypliny").Split(new char[] { ';' }));

            //var config = new List<string>(ConfigurationManager.AppSettings["eventType"].Split(new char[] { ';' }));
            //eventTypeComboBox.Items.AddRange(config.ToArray());
        }

        private void SportDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectValueComboBox.Items.AddRange(TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
            sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting(eventTypeComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void EventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            Event ev = new Event(databaseDownloader.GetHighestId("wydarzenia") + 1, eventNameTextBox.Text, eventDateTimePicker.Value);
            try
            {
                databaseDownloader.SetEvent(ev);
                resultLabel.Text = "Pomyślnie dodano wydarzenie o id " + ev.id;
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
