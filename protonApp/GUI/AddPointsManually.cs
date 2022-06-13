using protonApp.Data;
using protonApp.Logic;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class AddPointsManually : Form
    {
        DatabaseDownloader dd = new DatabaseDownloader();
        PointsCalculator pc = new PointsCalculator();
        TechnicalFunctions tf = new TechnicalFunctions();
        List<KeyValuePair<Student, int>> Students = new List<KeyValuePair<Student, int>>();
        public AddPointsManually()
        {
            InitializeComponent();
            f();

        }
        void f()
        {
            arePointsTransitiveCheckBox.Checked = true;
        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private string areAllEventFieldsValid()
        {
            if (eventNameTextBox.Text == "Nazwa wydarzenia" || eventNameTextBox.Text == "")
                return "NAZWA WYDARZENIA";
            else if (addedStudentsCheckedListBox.Items.Count == 0)
                return "DODANI UCZNIOWIE";
            return "0";
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (areAllEventFieldsValid() != "0")
            {
                MessageBox.Show("Błąd w polu " + areAllEventFieldsValid() + "!", "BŁAD KRYTYCZNY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Event _event = new Event(dd.GetHighestId("wydarzenia") + 1, getEventName(), getEventDate());
            try
            {
                dd.SetEvent(_event);
                MessageBox.Show("Pomyślnie dodano wydarzenie " + _event.name + " o id " + _event.id + " i dacie " + _event.date, "DODANO WYDARZENIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var logList = new List<Log>();
            foreach (KeyValuePair<Student, int> pair in Students)
            {
                int points = pair.Value;
                logList.Add(new Log(
                    dd.GetHighestId("log") + 1,
                    dd.GetStudentIdByParameters(pair.Key.name, pair.Key.surname, pair.Key.class_id),
                    points,
                    (arePointsTransitiveCheckBox.Checked) ? points : 0,
                    dd.GetHighestId("wydarzenia")));
                dd.InsertLog(logList.Last());
            }

            this.Close();
        }

        private string getEventName()
        {

            if (eventNameTextBox.Text != "Nazwa wydarzenia" && eventNameTextBox.Text != "")
            {
                return eventNameTextBox.Text.ToString();
            }
            else
            {
                eventNameTextBox.BackColor = Color.Red;
                MessageBox.Show("WPROWADŹ POPRAWNĄ NAZWĘ WYDARZENIA", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(tf.getSetting("waitAfterError")));
                eventNameTextBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }
        private DateTime getEventDate()
        {
            //Console.WriteLine(eventDateTimePicker.Value);
            if (eventDateTimePicker.Value != new DateTime(2000, 1, 1, 0, 0, 0))
            {
                return eventDateTimePicker.Value;
            }
            else
            {
                eventDateTimePicker.BackColor = Color.Red;
                MessageBox.Show("WYBIERZ POPRAWNĄ DATĘ", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(tf.getSetting("waitAfterError")));
                eventDateTimePicker.BackColor = Color.Empty;
                return new DateTime(1939, 9, 1, 4, 48, 0);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (getPoints() == -1)
                    return;
                List<string> selected = new List<string>();
                foreach (object itemChecked in studentsToAddCheckedListBox.CheckedItems)
                    selected.Add(itemChecked.ToString());
                var separated = new List<string>(dd.SplitStringIntoStudentsParameteres(selected[0]));
                Student student = dd.GetStudentByNameAndSurname(separated[0], separated[1]);
                Students.Add(new KeyValuePair<Student, int>(student, getPoints()));
                addedStudentsCheckedListBox.Items.Add(student.name + " " + student.surname + " " + dd.GetClassById(student.class_id).name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPRAWDŹ DANE! \n" + ex.Message, "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getPoints()
        {

            if (studentPointsNumericUpDown.Value != 0)
            {
                try
                {
                    return Convert.ToInt32(studentPointsNumericUpDown.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
            else
            {
                studentPointsNumericUpDown.BackColor = Color.Red;
                MessageBox.Show("WPROWADŹ POPRAWNE MIEJSCE ZAWODNIKA", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(tf.getSetting("waitAfterError")));
                studentPointsNumericUpDown.BackColor = Color.Empty;
                return -1;
            }
        }

        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            studentsToAddCheckedListBox.Items.Clear();
            var students = dd.GetStudentsBySurname(getSurname());
            foreach (Student student in students)
                studentsToAddCheckedListBox.Items.Add(student.name + " " + student.surname + " " + dd.GetClassById(student.class_id).name);
        }
        private string getSurname()
        {
            if (studentNameTextBox.Text != "Wprowadź nazwisko")
            {
                return studentNameTextBox.Text.ToString();
            }
            else
            {
                studentNameTextBox.BackColor = Color.Red;
                MessageBox.Show("WPROWADŹ POPRAWNE NAZWISKO", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(tf.getSetting("waitAfterError")));
                studentNameTextBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selected = new List<string>();
                foreach (object itemChecked in addedStudentsCheckedListBox.CheckedItems)
                    selected.Add(itemChecked.ToString());
                var separated = new List<string>(dd.SplitStringIntoStudentsParameteres(selected[0]));
                Student student = dd.GetStudentByNameAndSurname(separated[0], separated[1]);
                //var s = new Student(student.id, student.name, student.surname, student.class_id, student.sex);
                //var found = Students.Where(x => x.Key == student);
                KeyValuePair<Student, int> pair = new KeyValuePair<Student, int>(new Student(student.id, student.name, student.surname, student.class_id, student.sex), tf.GetStudentsPlaceByStudent(Students, new Student(student.id, student.name, student.surname, student.class_id, student.sex)));
                var _students = new List<KeyValuePair<Student, int>>(Students);
                Students.Clear();
                Students = tf.RemoveStudentFromList(_students, student);

                addedStudentsCheckedListBox.Items.Clear();
                foreach (KeyValuePair<Student, int> p in Students)
                    addedStudentsCheckedListBox.Items.Add(p.Key.name + " " + p.Key.surname + " " + dd.GetClassById(p.Key.class_id).name);
                //var allItems = addedStudentsCheckedListBox.Items.OfType<string>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            deleteStudentButton.Enabled = false;
        }

        private void eventNameTextBox_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "Nazwa wydarzenia")
                eventNameTextBox.Text = String.Empty;
        }

        private void studentNameTextBox_Click(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text == "Wprowadź nazwisko")
                studentNameTextBox.Text = String.Empty;
        }

        private void studentsToAddCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < studentsToAddCheckedListBox.Items.Count; i++)
                if (i != e.Index)
                    studentsToAddCheckedListBox.SetItemChecked(i, false);
        }

        private void addedStudentsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int sCount = addedStudentsCheckedListBox.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                sCount++;
            if (e.NewValue == CheckState.Unchecked)
                sCount--;
            for (int i = 0; i < addedStudentsCheckedListBox.Items.Count; i++)
                if (i != e.Index)
                    addedStudentsCheckedListBox.SetItemChecked(i, false);
            if (sCount > 0)
                deleteStudentButton.Enabled = true;
            else
                deleteStudentButton.Enabled = false;
        }
    }
}
