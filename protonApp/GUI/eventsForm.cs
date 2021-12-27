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
        public EventsForm()
        {
            InitializeComponent();
            initializeTextBoxes();
        }

        private void initializeTextBoxes()
        {
            DatabaseDownloader databaseDownloader = new DatabaseDownloader();
            List<Event> events = databaseDownloader.GetEvents();
            //eventsTextBox.Text = events.Aggregate("", (curr, next) => curr.ToString() + "\n");
            for (int i = 0; i < events.Count; i++)
                eventsTextBox.AppendText(events[i].id + ". " + events[i].name + ": " + events[i].date + "\r\n");
            //MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
            //MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM wydarzenia", sqlConnection);
            //var events = new List<string>();
            //Console.WriteLine("TEST");
            //try
            //{
            //    sqlConnection.Open();
            //    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //    while (sqlDataReader.Read())
            //    {
            //        events.Add(sqlDataReader["Id"] + ". " + sqlDataReader["Nazwa"] + ": " + sqlDataReader["Data"]);
            //        //TODO usunąć te dziwne zera, czyli godzinę
            //        //events[events.Count].Remove(events.LastIndexOf(" 0"));
            //        Console.WriteLine(sqlDataReader["Data"]);
            //    }
            //    sqlDataReader.Close();

            //} catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
            //for (int i = 0; i < events.Count; i++)
            //    eventsTextBox.AppendText(events[i] + "\r\n");
            ////eventsTextBox.Text = events.Aggregate("", (a, b) => a + "\n");
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
    }
}
