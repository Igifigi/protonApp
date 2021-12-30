using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using protonApp.Data;
using protonApp.Model;
using protonApp.Logic;
using System.Text.RegularExpressions;

namespace protonApp.GUI
{
    public partial class AddEventForm : Form
    {
        DatabaseDownloader dbD = new DatabaseDownloader();
        PointsCalculator pc = new PointsCalculator();
        //TechnicalFunctions technicalFunctions = new TechnicalFunctions();
        List<KeyValuePair<Student, int>> Students = new List<KeyValuePair<Student, int>>();
        public AddEventForm()
        {
            InitializeComponent();
            initializeComboBoxesAndGropuBoxes();
        }
        private void disableOtherFunctions()
        {
            switch (eventTypeComboBox.SelectedItem)
            {
                case "Dyscypliny indywidualne":
                    individualSportsGroupBox.Visible = true;
                    break;
                case "Dyscypliny zespołowe":
                    individualSportsGroupBox.Visible = false;
                    break;



            }
        }

        private void EventNameTextBox_Click(Object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "Nazwa wydarzenia")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
            }
            
        }



        private void MatchCountTextBox_Click(Object sender, EventArgs e)
        {
            if(matchCountTextBox.Text == "Ilość meczy")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
            }
        }

        private void initializeComboBoxesAndGropuBoxes()
        {
            eventTypeComboBox.Items.AddRange(TechnicalFunctions.getSetting("Typ wydarzeń").Split(new char[] { ';' }));
            individualSportsGroupBox.Visible = false;
            organizationGroupBox.Visible = false;
            teamIndividualSportsGroupBox.Visible = false;
            teamSportsGroupBox.Visible = false;

            //sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting("Dyscypliny").Split(new char[] { ';' }));

            //var config = new List<string>(ConfigurationManager.AppSettings["eventType"].Split(new char[] { ';' }));
            //eventTypeComboBox.Items.AddRange(config.ToArray());
        }

        private void SportDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectValueComboBox.Items.AddRange(TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
            sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting(eventTypeComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
            disableOtherFunctions();

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void EventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            Event _event = new Event(dbD.GetHighestId("wydarzenia") + 1, eventNameTextBox.Text, eventDateTimePicker.Value);
            try
            {
                dbD.SetEvent(_event);
                resultLabel.Text = "Pomyślnie dodano wydarzenie o id " + _event.id;
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
            string sDCB = "";
            try
            {
            sDCB = sportDisciplineComboBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz dyscyplinę!");
            }

            var logList = new List<Log>();
            //grade todo
            foreach(KeyValuePair<Student, int> pair in Students)
            {
                int points = pc.calculatePoints(
                    eventTypeComboBox.SelectedItem.ToString(),
                    isRelayCheckBox.Checked,
                    isRelayCheckBox.Checked ? Convert.ToInt32(relayCountTextBox.Text) : 0,
                    isRelayCheckBox.Checked ? Convert.ToInt32(peopleCountTextBox.Text) : 0,
                    (sDCB == "Szachy" || sDCB == "Pływanie") ? true : false,
                    isRelayCheckBox.Checked ? 0 : Convert.ToInt32(peopleCountTextBox.Text),
                    (sDCB != "Trening" && sDCB != "Organizacja" && sDCB != "Sędziowanie") ? pair.Value : 0,
                    sDCB == "Sędziowanie" ? 0 : 0, //TODO organizacja punkty
                    sDCB == "Organizacja" ? higherRankEventCheckBox.Checked : false,
                    sDCB == "Dyscypliny zespołowe" ? Convert.ToInt32(teamCountTextBox.Text) : 0,
                    (sDCB == "Ping pong" || sDCB == "Badminton" || sDCB == "Ringo" || sDCB == "Streetball" || sDCB == "Brydż") ? true : false,
                    sDCB == "Dyscypliny zespołowe" ? Convert.ToInt32(matchCountTextBox.Text) : 0,
                    sDCB == "Dyscypliny indywidualne drużynowe" ? championsTypeComboBox.SelectedItem.ToString() : "");
                logList.Add(new Log(
                    dbD.GetHighestId("log") + 1,
                    dbD.GetStudentIdByParameters(pair.Key.name, pair.Key.surname, pair.Key.class_id),
                    points,
                    0, //todo punkty przechodnie
                    _event.id));
                dbD.InsertLog(logList.Last());
 
            }

            //int points;
            
        

            //Log _log = new Log(dbD.GetHighestId("log") + 1, )
        }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            studentNameComboBox.Items.Clear();
            //Console.WriteLine("XDDD");
            var students = dbD.GetStudentsBySurname(studentNameTextBox.Text);
            foreach(Student student in students)
            {
                
                studentNameComboBox.Items.Add(student.name + " " + student.surname + " " + dbD.GetClassById(student.class_id).name);
                
            }


            
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string[] separated = studentNameComboBox.SelectedItem.ToString().Split(new char[] { ' ' });
            Student student = dbD.GetStudentByNameAndSurname(separated[0], separated[1]);
            Students.Add(new KeyValuePair<Student, int>(student, Convert.ToInt32(playerPlaceTextBox.Text)));
            showStudentsListBox.Items.Add(student.name + " " + student.surname + " " + dbD.GetClassById(student.class_id).name);
        }

        private void StudentNameTextBox_Click_1(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text == "Wprowadź nazwisko")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
            }
        }

        private void GradeForOrganisationTextBox_Click(object sender, EventArgs e)
        {
            if(gradeForOrganisationTextBox.Text == "Ocena")
            {
                gradeForOrganisationTextBox.Text = "";
            }
        }
    }
}
