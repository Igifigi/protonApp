using System.Configuration;
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
using protonApp.GUI;
using protonApp.Model;
using protonApp.Logic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using protonApp.Data;
using Newtonsoft.Json;

namespace protonApp.GUI
{
    public partial class NewMainForm : Form
    {
        OtherDatabaseModifications odm = new OtherDatabaseModifications();
        DatabaseDownloader dd = new DatabaseDownloader();
        UserCommunication uc = new UserCommunication();
        TechnicalFunctions tf = new TechnicalFunctions();
        MemoryManager mm = new MemoryManager();

        public NewMainForm()
        {
            InitializeComponent();
            SetVersion();
            SetDefaultSex();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTabControl.SelectedTab.ToString().Remove(0, 10))
            {
                case "Strona główna}":
                    MainTab();
                    break;
                case "Wydarzenia}":
                    EventsTab();
                    break;
                case "Uczniowie}":
                    StudentsTab();
                    break;
                case "Ranking}":
                    RankingTab();
                    break;
                case "Ustawienia}":
                    SettingsTab();
                    break;
                default:
                    MainTab();
                    break;
            }
        }

        private void MainTab()
        {
            SetVersion();
        }
        private void EventsTab()
        {
            RefreshEventTextBoxes();
        }
        private void StudentsTab()
        {
            RefreshStudentList();
        }
        private void RankingTab()
        {
            RefreshRankingList();
        }
        private void SettingsTab()
        {
            RefreshSettings();
        }

        #region Main Page

        //EVENT HANDLERS
        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Igifigi/protonApp/blob/master/README.md");
        }

        private void SubmitIssueButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Igifigi/protonApp/issues");
        }

        //HELPER FUNCTIONS
        private void SetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionLabel.Text = "v." + fileVersionInfo.FileVersion.ToString();
        }

        #endregion

        #region Event Page

        //HELPER FUNCTIONS
        private void RefreshEventTextBoxes()
        {
            List<Event> events = dd.GetEvents();
            EventsCheckedListBox.Items.Clear();
            foreach (Event e in events)
                EventsCheckedListBox.Items.Add(e.id + ": " + e.name + " " + e.date.ToString("dd/MM/yyyy"));
        }

        //EVENT HANDLERS
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEventForm aef = new AddEventForm();
            aef.ShowDialog();
        }

        private void EditEventButton_Click(object sender, EventArgs e)
        {
            uc.ShowInfoBox("Funkcja niedostępna, przepraszamy!");
        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            if (!uc.ShowQuestionBox("Czy na pewno chcesz usunąć zaznaczone wydarzenia?"))
                return;

            List<string> selected_events = new List<string>();
            foreach(object selected_event in EventsCheckedListBox.CheckedItems)
            {
                selected_events.Add(selected_event.ToString());
                string selected_event_id = new string(selected_event.ToString().TakeWhile(char.IsDigit).ToArray());
                odm.sendDirectQuery("DELETE FROM log WHERE Wydarzenie_Id=" + selected_event_id);
                odm.sendDirectQuery("DELETE FROM wydarzenia WHERE id=" + selected_event_id);
            }
            RefreshEventTextBoxes();
            DeleteEventButton.Enabled = false;
        }

        private void RefreshEventsButton_Click(object sender, EventArgs e)
        {
            RefreshEventTextBoxes();
        }

        private void EventsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selected_items_amount = EventsCheckedListBox.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                selected_items_amount++;
            if (e.NewValue == CheckState.Unchecked)
                selected_items_amount--;
            if (selected_items_amount > 0)
                DeleteEventButton.Enabled = true;
            else
                DeleteEventButton.Enabled = false;
        }


        #endregion

        #region Students Page

        //HELPER FUNCTIONS
        private void RefreshStudentList()
        {
            List<Student> students = dd.GetStudents();
            StudentsCheckedListBox.Items.Clear();
            foreach(Student student in students)
                StudentsCheckedListBox.Items.Add(student.name + " " + student.surname + " " + dd.GetClassById(student.class_id).name);
        }

        private int GetSelectedStudentId()
        {
            string selected_student = StudentsCheckedListBox.CheckedItems[0].ToString();
            List<string> separated_values = selected_student.Split(' ').ToList();
            string _name = separated_values[0];
            string _surname = separated_values[1];
            string _class = separated_values[2];
            return dd.GetStudentIdByParameters(_name, _surname, dd.GetClassIdByName(_class));
        }

        //EVENT HANDLERS
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm();
            asf.ShowDialog();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            EditStudentButton.Enabled = false;
            StudentEditForm sef = new StudentEditForm(GetSelectedStudentId());
            sef.ShowDialog();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (!uc.ShowQuestionBox("Czy napewno checesz usunąć wybranego ucznia?"))
                return;
            dd.DeleteStudentById(GetSelectedStudentId());
        }

        private void RefreshStudentsButton_Click(object sender, EventArgs e)
        {
            RefreshStudentList();
        }

        private void StudentsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < StudentsCheckedListBox.Items.Count; i++)
                if (i != e.Index)
                    StudentsCheckedListBox.SetItemChecked(i, false);
        }

        private void StudentsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsCheckedListBox.CheckedItems.Count != 1)
                EditStudentButton.Enabled = false;
            else
                EditStudentButton.Enabled = true;
            if (StudentsCheckedListBox.CheckedItems.Count != 0)
                DeleteStudentButton.Enabled = false;
            else
                DeleteStudentButton.Enabled = true;
        }

        #endregion

        #region Ranking Page

        //HELPER FUNCTIONS
        private void RefreshRankingList()
        {
            IndividualRankingListBox.Items.Clear();
            ClassRankingListBox.Items.Clear();
            ShowRanking(CreateRanking());
        }

        private void ShowRanking(Ranking ranking)
        {
            for (int i = 0; i < NumberOfStudentsToDisplayNumericUpDown.Value; i++)
                if (i < ranking.students.Count())
                    IndividualRankingListBox.Items.Add(
                        i + 1 + ". " +
                        ranking.students[i].name + " " +
                        ranking.students[i].surname + " " +
                        dd.GetClassById(ranking.students[i].class_id).name + " " +
                        ranking.students[i].points + "pkt"
                        );
            for (int i = 0; i < dd.GetClasses().Count; i++)
                ClassRankingListBox.Items.Add(
                    i + 1 + ". " +
                    ranking.classes[i].name + " " +
                    ranking.classes[i].points + "pkt"
                    );
        }
        private Ranking CreateRanking()
        {
            List<Log> logs = dd.GetLogs();
            List<Student> _students = dd.GetStudents();
            List<Class> _classes = dd.GetClasses();
            List<PointedStudent> students = new List<PointedStudent>();
            List<PointedClass> classes = new List<PointedClass>();

            foreach (Student student in _students)
            {
                switch (SelectSexComboBox.SelectedItem.ToString())
                {
                    case "Obie":
                        PointedStudent pointed_student = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                        break;
                    case "Dziewczyny":
                        PointedStudent female_pointed_student = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                        if (female_pointed_student.sex == 0)
                            students.Add(female_pointed_student);
                        break;
                    case "Chłopcy":
                        PointedStudent male_pointed_student = new PointedStudent(student.id, student.name, student.surname, student.class_id, student.sex, 0);
                        if (male_pointed_student.sex == 1)
                            students.Add(male_pointed_student);
                        break;
                }
            }

            foreach(Class _class in _classes)
            {
                PointedClass pointed_class = new PointedClass(_class.id, _class.name, 0);
                classes.Add(pointed_class);
            }

            foreach(Log log in logs)
            {
                foreach(PointedStudent pointed_student in students)
                {
                    if(pointed_student.id == log.student_id)
                    {
                        pointed_student.points += log.points;
                        if (log.transitive_points == 1)
                            foreach (PointedClass pointed_class in classes)
                                if (pointed_class.id == pointed_student.class_id)
                                    pointed_class.points += log.points;
                    }
                }
            }
            students = students.OrderBy(o => -(o.points)).ToList();
            classes = classes.OrderBy(o => -(o.points)).ToList();

            return new Ranking(students, classes);
        }

        private void CreatePDF(string text, PdfSharp.Pdf.PdfDocument doc, List<string> students, SaveFileDialog sfd, int x)
        {
            string file_path = null;
            file_path = sfd.FileName;
            PdfPage page = doc.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            graphics.DrawString(text, new XFont("Arial", 35, XFontStyle.Bold), XBrushes.Red, new XPoint(x, 70));
            graphics.DrawLine(new XPen(XColor.FromArgb(94, 0, 0)), new XPoint(100, 100), new XPoint(500, 100));
            int num = 0;
            foreach(string student in students)
            {
                num++;
                graphics.DrawString(student, new XFont("Arial", 15), XBrushes.Black, new XPoint(100, 150 + 30 * num));
            }
            doc.Save(file_path);
        }

        private void SetDefaultSex()
        {
            SelectSexComboBox.SelectedIndex = 0;
        }

        //EVENT HANDLERS

        private void NumberOfStudentsToDisplayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RefreshRankingList();
        }
        private void CreateRankingPDFButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "pdf files (*.pdf)|*.pdf";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            PdfDocument doc = new PdfDocument();
            SelectSexComboBox.SelectedItem = "Obie";
            RefreshRankingList();
            CreatePDF("Ranking ogólny", doc, tf.ConvertToStringList(IndividualRankingListBox), sfd, 160);
            SelectSexComboBox.SelectedItem = "Obie";
            RefreshRankingList();
            CreatePDF("Ranking męski", doc, tf.ConvertToStringList(IndividualRankingListBox), sfd, 170);
            SelectSexComboBox.SelectedItem = "Chłopcy";
            RefreshRankingList();
            CreatePDF("Ranking żeński", doc, tf.ConvertToStringList(IndividualRankingListBox), sfd, 160);
            SelectSexComboBox.SelectedItem = "Dziewczyny";
            RefreshRankingList();
            CreatePDF("Ranking klas", doc, tf.ConvertToStringList(ClassRankingListBox), sfd, 180);
        }

        private void SelectSexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshRankingList();
        }

        private void RefreshRankingButton_Click(object sender, EventArgs e)
        {
            RefreshRankingList();
        }




        #endregion

        #region Settings Page

        //HELPER FUNCTIONS
        private void RefreshSettings()
        {
            SelectKeyComboBox.Items.AddRange(ConfigurationManager.AppSettings.AllKeys.ToArray());
            string read_from_memory = mm.GetConnectionString();
            List<char> chars_to_remove = new List<char> { '"' };
            chars_to_remove.ForEach(c => read_from_memory = read_from_memory.Replace(c.ToString(), String.Empty));
            if (read_from_memory == "")
                read_from_memory = "datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True";
            FullConnectionStringTextBox.Text = read_from_memory;
        }

        //EVENT HANDLERS
        private void SelectKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectValueComboBox.Items.Clear();
            SelectValueComboBox.Items.Add(tf.getSetting(SelectKeyComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
        }

        private void AddValueButton_Click(object sender, EventArgs e)
        {
            tf.setSetting(SelectKeyComboBox.SelectedItem.ToString(), tf.getSetting(SelectKeyComboBox.SelectedItem.ToString() + ";" + InsertValueTextBox.Text));
        }

        private void EditValueButton_Click(object sender, EventArgs e)
        {
            string selected_item = SelectKeyComboBox.SelectedItem.ToString();
            string to_edit = SelectValueComboBox.SelectedItem.ToString();
            string actual_value = tf.getSetting(selected_item);
            int delete_amount = actual_value.IndexOf(to_edit);
            string value = actual_value.Remove(delete_amount - 1, to_edit.Length);
            tf.setSetting(selected_item, value + ";" + InsertValueTextBox.Text);
        }

        private void DeleteValueButton_Click(object sender, EventArgs e)
        {
            string selected_item = SelectKeyComboBox.SelectedItem.ToString();
            string to_edit = SelectValueComboBox.SelectedItem.ToString();
            string actual_value = tf.getSetting(selected_item);
            int delete_amount = actual_value.IndexOf(to_edit);
            string value = actual_value.Remove(delete_amount - 1, to_edit.Length);
            tf.setSetting(selected_item, value);
        }

        private void DirectDatabaseQueryButton_Click(object sender, EventArgs e)
        {
            DirectDatabaseQueryForm ddqf = new DirectDatabaseQueryForm();
            ddqf.ShowDialog();
        }

        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            string connection = "datasource=" + DataSourceTextBox.Text + ";port=" + PortTextBox.Text + ";username=" + UsernameTextBox.Text + ";password=" + PasswordTextBox.Text + ";database=proton;convert zero datetime=True";
            try
            {
                mm.SetConnectionString(connection);
                uc.ShowInfoBox("Pomyślnie ustawiono połączenie z serwerem na " + connection);
            }
            catch (Exception ex)
            {
                uc.ShowErrorBox(ex.Message);
            }
        }

        private void CommitConnectionStringButton_Click(object sender, EventArgs e)
        {
            string connection = FullConnectionStringTextBox.Text;
            try
            {
                mm.SetConnectionString("" + connection + "");
                uc.ShowInfoBox("Pomyślnie ustawiono połączenie z serwerem na " + connection);
            }
            catch (Exception ex)
            {
                uc.ShowErrorBox(ex.Message);
            }
        }

        private void ResetValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                tf.setSetting(SelectKeyComboBox.SelectedItem.ToString(), tf.GetValueByKey(StaticSettingsData.data, SelectKeyComboBox.SelectedItem.ToString()));
                uc.ShowInfoBox("Pomyślnie zresetowano klucz " + SelectKeyComboBox.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                uc.ShowErrorBox(ex.Message);
            }
        }

        #endregion


    }
}
