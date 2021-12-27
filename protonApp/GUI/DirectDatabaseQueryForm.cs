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

namespace protonApp.GUI
{
    public partial class DirectDatabaseQueryForm : Form
    {
        public DirectDatabaseQueryForm()
        {
            InitializeComponent();
            chooseQueryMethodComboBox.Items.Add("SELECT");
            chooseQueryMethodComboBox.Items.Add("INSERT, UPDATE, DELETE");
            chooseQueryMethodComboBox.Items.Add("SELECT (*)");
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            sendDirectQuery();
        }

        //private short transfer()
        //{
        //    if(chooseQueryMethodComboBox.SelectedIndex)
        //}

        private void sendDirectQuery()
        {
            MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
            MySqlCommand sendQuery = new MySqlCommand(queryTextbox.Text, sqlConnection);
            //MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();

            try
            {
                sqlConnection.Open();
                Console.WriteLine("connection established");

                switch (chooseQueryMethodComboBox.SelectedIndex)
                {
                    case 0:
                        Console.WriteLine("selected 'select' query");

                        List<string> output = new List<string>();
                
                        MySqlDataReader sqlDataReader = sendQuery.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            //output.Add(sqlDataReader[0].ToString() + " " + s)
                            //MessageBox.Show((sqlDataReader[0].ToString() + " -- " + sqlDataReader[1].ToString()));
                        }
                        break;

                    case 1:
                        Console.WriteLine("selected 'insert etc.' query");
                        sendQuery.ExecuteNonQuery();
                        break;
                }

                sqlConnection.Close();
                


            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            

            

        }

        private void DirectDatabaseQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
