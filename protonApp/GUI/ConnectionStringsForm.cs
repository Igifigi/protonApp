using protonApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace protonApp.GUI
{
    
    public partial class ConnectionStringsForm : Form
    {
        TechnicalFunctions tf = new TechnicalFunctions();
        public ConnectionStringsForm()
        {
            InitializeComponent();
            initializeTextBoxes();
        }

        private void ConnectionStringsForm_Load(object sender, EventArgs e)
        {

        }

        private void initializeTextBoxes()
        {
            List<string> data = new List<string>(TechnicalFunctions.getConnectionString("dbConfig").Split(new char[] { ';' }));
            dataSourceTextBox.Text = data[0];
            portTextBox.Text = data[1];
            usernameTextBox.Text = data[2];
            passwordTextBox.Text = data[3];
            initializeDisplayLabel(data);
        }
        private void initializeDisplayLabel(List<string> data)
        {
            displayConnectionString.Text = data.Aggregate("", (a, b) => a + "\n" + b);
        }

        private void DataSourceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TechnicalFunctions.setConnectionString("dbConfig", dataSourceTextBox.Text + ";" + portTextBox.Text + ";" + usernameTextBox.Text + ";" + passwordTextBox.Text + ";database=proton;convert zero datetime=True");
        }

        //<add name = "dbConfig" connectionString="datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True"/>
    }
}
