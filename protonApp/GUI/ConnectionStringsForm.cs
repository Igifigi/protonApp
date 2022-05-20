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
        MemoryManager mm = new MemoryManager();
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
            string read_from_memory = mm.GetConnectionString();
            List<char> chars_to_remove = new List<char> { '"' };
            chars_to_remove.ForEach(c => read_from_memory = read_from_memory.Replace(c.ToString(), String.Empty));
            //List<string> data = new List<string>(read_from_memory.Split(new char[] { ';' }));
            //dataSourceTextBox.Text = data[0];
            //portTextBox.Text = data[1];
            //usernameTextBox.Text = data[2];
            //passwordTextBox.Text = data[3];
            if (read_from_memory == "")
                read_from_memory = "datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True";
            fullConnectionStringTextBox.Text = read_from_memory;
            //TODO szyfrowanie
        }


        private void DataSourceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CommitChangesButton_Click(object sender, EventArgs e)
        {
            string connection = "datasource="+dataSourceTextBox.Text + ";port=" + portTextBox.Text + ";username=" + usernameTextBox.Text + ";password=" + passwordTextBox.Text + ";database=proton;convert zero datetime=True";
            try
            {
                mm.SetConnectionString(connection);
                //TechnicalFunctions.setConnectionString("dbConfig", connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Pomyślnie ustawiono połączenie z serwerem na " + connection, "Pomyślnie zapisano dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void commitChangesButton2_Click(object sender, EventArgs e)
        {
            string conn = fullConnectionStringTextBox.Text;
            try
            {
                mm.SetConnectionString("\"" + conn + "\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Pomyślnie ustawiono połączenie z serwerem na " + conn, "Pomyślnie zapisano dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //<add name = "dbConfig" connectionString="datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True"/>
    }
}
