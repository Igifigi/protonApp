using MySql.Data.MySqlClient;
using protonApp.Data;
using protonApp.Logic;
using protonApp.Model;
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
        DatabaseDownloader databaseDownloader = new DatabaseDownloader();
        public AddStudentForm()
        {
            InitializeComponent();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            List<Class> classes = databaseDownloader.GetClasses();
            for(int i = 0; i < classes.Count; i++)
            {
                selectClassComboBox.Items.Add(classes[i].name);
            }
            //selectClassComboBox.Items.AddRange(databaseDownloader.GetClasses().ToArray());
        }

        private void InsertStudent()
        {
            MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
            string cmd = 
                "INSERT INTO uczniowie (Imie, Nazwisko, Plec, Klasa_Id) VALUES ('" + 
                nameTextBox.Text + 
                "', '" 
                + surnameTextBox.Text + 
                "', " + 
                getSex() + 
                ", " + 
                databaseDownloader.GetClassIdByName(selectClassComboBox.SelectedItem.ToString()) + 
                ")";

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(cmd, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
           


        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (!(nameTextBox.Text == "" ||
                surnameTextBox.Text == "" || 
                (menRadioButton.Checked == false && womenRadioButton.Checked == false) || 
                selectClassComboBox.SelectedItem == null ||
                TechnicalFunctions.HaveSpace(nameTextBox.Text) ||
                TechnicalFunctions.HaveSpace(surnameTextBox.Text)))
            {
                InsertStudent();
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                menRadioButton.Checked = false;
                womenRadioButton.Checked = false;

                if (MessageBox.Show("Czy chcesz dodać następnego ucznia?", "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Któraś z podanych danych jest nieprawidłowa", "Ostrzeżenie", MessageBoxButtons.OK);
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
        //private void sendDirectQuerry()
        //{
        //    MySqlConnection sqlConnection = new MySqlConnection(DatabaseConnectionData.connectionData);
        //    string cmd = "INSERT INTO uczniowie (Imie, Nazwisko, Plec, Klasa_Id) VALUES ('" + nameTextBox.Text + "', '" + surnameTextBox.Text + "', " + getSex() + ", " + 1 + ")";
        //    //MySqlCommand sendQuery = new MySqlCommand("INSERT INTO uczniowie(Imie,Nazwisko,Plec,Klasa_Id) VALUES('" + nameTextBox.Text + "', '" + surnameTextBox.Text + "', " + getSex() + ", " + 1 + ")", sqlConnection);
        //    //MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();

        //    try
        //    {
        //        sqlConnection.Open();
        //        //Console.WriteLine("connection established");
        //        //Console.WriteLine(cmd);
        //        MySqlCommand sqlCommand= new MySqlCommand(cmd, sqlConnection);
        //        sqlCommand.ExecuteNonQuery();
        //        sqlConnection.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    sqlConnection.Close();
        //}
        private bool getSex()
        {
            if (menRadioButton.Checked)
                return true;
            else if (womenRadioButton.Checked)
                return false;
            else
                return false;
        }
    }
}
