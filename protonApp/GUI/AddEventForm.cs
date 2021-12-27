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

namespace protonApp.GUI
{
    public partial class AddEventForm : Form
    {
        //TechnicalFunctions technicalFunctions = new TechnicalFunctions();
        public AddEventForm()
        {
            InitializeComponent();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            eventTypeComboBox.Items.AddRange(TechnicalFunctions.getSetting("Typ wydarzeń").Split(new char[] { ';' }));
            sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting("Dyscypliny").Split(new char[] { ';' }));

            //var config = new List<string>(ConfigurationManager.AppSettings["eventType"].Split(new char[] { ';' }));
            //eventTypeComboBox.Items.AddRange(config.ToArray());
        }
    }
}
