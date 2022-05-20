using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using protonApp.Data;
using protonApp.Model;
using Newtonsoft.Json;

namespace protonApp.GUI
{
    public partial class DeveloperToolsForm : Form
    {
        public DeveloperToolsForm()
        {
            InitializeComponent();
        }

        

        private void saveAllEventsIntoJSONFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TechnicalFunctions.setSetting("saveEventsToJSON", saveAllEventsIntoJSONFileCheckBox.Checked.ToString());
        }

    }
}
