using MySql.Data.MySqlClient;
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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            sendDirectQuerry();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void sendDirectQuerry()
        {
            string text = "INSERT INTO uczniowie(Imie,Nazwisko,Płeć,Klasa_Id) VALUES('"+Namer.Text+"', '"+Surname.Text+"', "+sexCheck()+", "+1+")";
            MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
            MySqlCommand sendQuery = new MySqlCommand(text, sqlConnection);
            //MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();

            try
            {
                sqlConnection.Open();
                Console.WriteLine("connection established");
                Console.WriteLine(text);
                MySqlCommand mySqlCommand= new MySqlCommand(text, sqlConnection);
                mySqlCommand.ExecuteNonQuery();
                sqlConnection.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
        }
        private bool sexCheck()
        {
            if (radioButton1.Checked)return true;
            else if (radioButton2.Checked) return false;
            else return false;
        }
    }
}
