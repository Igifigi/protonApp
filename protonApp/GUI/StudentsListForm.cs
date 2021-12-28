using MySql.Data.MySqlClient;
using protonApp.Data;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
            Refresh();
           
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm  addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            StudentEditForm editStudentForm = new StudentEditForm();
            editStudentForm.ShowDialog();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
            MySqlCommand getStudents = new MySqlCommand("SELECT * FROM uczniowie", sqlConnection);

            try
            {
                sqlConnection.Open();
                Console.WriteLine("connection established");
                MySqlDataReader dr = getStudents.ExecuteReader();
               while (dr.Read())
                {
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
        }
    }
}
