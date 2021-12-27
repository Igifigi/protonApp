using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using protonApp.Data;

namespace protonApp.GUI
{
    public partial class EventsForm : Form
    {
        DatabaseConnectionData databaseConnectionData = new DatabaseConnectionData();
        public EventsForm()
        {
            InitializeComponent();
        }

        private void downloadData()
        {
            
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.ShowDialog();
        }
    }
}
