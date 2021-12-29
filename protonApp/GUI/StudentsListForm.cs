using MySql.Data.MySqlClient;
using protonApp.Data;
using protonApp.Logic;
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
        OtherDatabaseModifications md = new OtherDatabaseModifications();
        DatabaseDownloader dl = new DatabaseDownloader();
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
 
                StudentEditForm studentEditForm =new StudentEditForm();
                studentEditForm.ShowDialog();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (checkedListBox1.CheckedItems.Count !=1)editStudent.Enabled = false;
                else editStudent.Enabled = true;
                if (checkedListBox1.CheckedItems.Count == 0) removeStudent.Enabled = false;
                else removeStudent.Enabled = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
          List<Student> Studenci = dl.GetStudents();
            checkedListBox1.Items.Clear();
            for(int i = 0; i < Studenci.Count; i++)
            {
                Student student = Studenci[i];
                string klasa = dl.GetClassById(student.class_id).name;
                string tekst = student.name + " " + student.surname + " " + klasa;
                checkedListBox1.Items.Add(tekst);
            }
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno checesz usunąć uczniów?", "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteCheckedStudents();
            }
        }
        private void deleteCheckedStudents()
        {
            foreach(object itemChecked in checkedListBox1.CheckedItems)
            {
                string name=itemChecked.ToString().Split(' ')[0];
                string surname = itemChecked.ToString().Split(' ')[1];
                string klasa = itemChecked.ToString().Split(' ')[2];
                string Text= "DELETE FROM uczniowie where id=" + dl.GetStudentIdByParameters(name, surname, dl.GetClassIdByName(klasa));
                md.sendDirectQuery(Text);
            }
        }
    }
}
