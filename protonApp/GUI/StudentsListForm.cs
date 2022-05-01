using protonApp.Logic;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class StudentsListForm : Form
    {
        public static int id;
        OtherDatabaseModifications md = new OtherDatabaseModifications();
        DatabaseDownloader dl = new DatabaseDownloader();
        public StudentsListForm()
        {
            InitializeComponent();
            RefreshList();
            Refresh();
           
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            string ItemChecked = StudentsCheckedListBox.CheckedItems[0].ToString();
            string name = ItemChecked.ToString().Split(' ')[0];
            string surname = ItemChecked.ToString().Split(' ')[1];
            string klasa = ItemChecked.ToString().Split(' ')[2];
            editStudentButton.Enabled = false;
            id = dl.GetStudentIdByParameters(name, surname, dl.GetClassIdByName(klasa));
            StudentEditForm studentEditForm = new StudentEditForm(id);
            studentEditForm.ShowDialog();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsCheckedListBox.CheckedItems.Count != 1) editStudentButton.Enabled = false;
            else editStudentButton.Enabled = true;
            if (StudentsCheckedListBox.CheckedItems.Count == 0) removeStudentButton.Enabled = false;
            else removeStudentButton.Enabled = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            List<Student> Studenci = dl.GetStudents();
            StudentsCheckedListBox.Items.Clear();
            for (int i = 0; i < Studenci.Count; i++)
            {
                Student student = Studenci[i];
                string klasa = dl.GetClassById(student.class_id).name;
                string tekst = student.name + " " + student.surname + " " + klasa;
                StudentsCheckedListBox.Items.Add(tekst);
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
            foreach (object itemChecked in StudentsCheckedListBox.CheckedItems)
            {
                string name = itemChecked.ToString().Split(' ')[0];
                string surname = itemChecked.ToString().Split(' ')[1];
                string klasa = itemChecked.ToString().Split(' ')[2];
                string Text = "DELETE FROM uczniowie where id=" + dl.GetStudentIdByParameters(name, surname, dl.GetClassIdByName(klasa));
                md.sendDirectQuery(Text);
            }
        }
    }
}
