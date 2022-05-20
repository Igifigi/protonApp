using protonApp.Data;
using protonApp.Logic;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class EventsForm : Form
    {
        //DatabaseConnectionData databaseConnectionData = new DatabaseConnectionData();
        OtherDatabaseModifications odm = new OtherDatabaseModifications();
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

            foreach (Event e in events)
                eventsCheckedListBox.Items.Add(e.id + ": " + e.name + " " + e.date.ToString("dd/MM/yyyy"));
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
            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone wydarzenia?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                deleteCheckedEvents();
        }

        private void deleteCheckedEvents()
        {
            List<string> selected = new List<string>();
            //string pattern = @"([1-999999999]):+";
            foreach (object itemChecked in eventsCheckedListBox.CheckedItems)
            {
                selected.Add(itemChecked.ToString());
                string event_id = new string(itemChecked.ToString().TakeWhile(char.IsDigit).ToArray());
                odm.sendDirectQuery("DELETE FROM log WHERE Wydarzenie_Id=" + event_id);
                odm.sendDirectQuery("DELETE FROM wydarzenia WHERE id=" + event_id);
            }
            initializeTextBoxes();
            deleteEventButton.Enabled = false;
        }

        private void EventsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int sCount = eventsCheckedListBox.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                sCount++;
            if (e.NewValue == CheckState.Unchecked)
                sCount--;
            if (sCount > 0)
                deleteEventButton.Enabled = true;
            else
                deleteEventButton.Enabled = false;
        }
    }
}
