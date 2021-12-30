using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using protonApp.Data;
using protonApp.Model;
using protonApp.Logic;

namespace protonApp.GUI
{
    public partial class EventsForm : Form
    {
        DatabaseConnectionData databaseConnectionData = new DatabaseConnectionData();
        DatabaseDownloader databaseDownloader = new DatabaseDownloader();
        //SELECT Nazwa FROM `wydarzenia` WHERE Nazwa LIKE '%a%'
        public EventsForm()
        {
            InitializeComponent();
            initializeTextBoxes();
        }

        private void initializeTextBoxes()
        {
            List<Event> events = databaseDownloader.GetEvents();
            eventsCheckedListBox.Items.Clear();

            foreach(Event e in events)
                eventsCheckedListBox.Items.Add(e.name + " " + e.date.Date);
        }

        private void downloadData()
        {
            
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.ShowDialog();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            initializeTextBoxes();
        }

        private void eventsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditEventButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {

        }
    }
}
