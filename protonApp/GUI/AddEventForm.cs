using protonApp.Data;
using protonApp.Logic;
using protonApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace protonApp.GUI
{
    public partial class AddEventForm : Form
    {
        DatabaseDownloader dbD = new DatabaseDownloader();
        MemoryManager mm = new MemoryManager();
        PointsCalculator pc = new PointsCalculator();
        TechnicalFunctions tf = new TechnicalFunctions();
        List<KeyValuePair<Student, int>> Students = new List<KeyValuePair<Student, int>>();

        public AddEventForm()
        {
            InitializeComponent();
            initializeComboBoxesAndGroupBoxes();
        }


        private void EventNameTextBox_Click(Object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "Nazwa wydarzenia")
                eventNameTextBox.Text = String.Empty;

        }

        private void initializeComboBoxesAndGroupBoxes()
        {
            eventTypeComboBox.Items.AddRange(TechnicalFunctions.getSetting("Typ wydarzeń").Split(new char[] { ';' }));
            championsTypeComboBox.Items.AddRange(TechnicalFunctions.getSetting("championsType").Split(new char[] { ';' }));
            individualSportsGroupBox.Enabled = false;
            organizationGroupBox.Enabled = false;
            teamIndividualSportsGroupBox.Enabled = false;
            teamSportsGroupBox.Enabled = false;
        }

        private void SportDisciplineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGradeNumericUpDownBrackets();
        }

        private void EventTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectValueComboBox.Items.AddRange(TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
            sportDisciplineComboBox.Items.Clear();

            if(getEventType() == "Organizacja" || getEventType() == "Sędziowanie")
            {
                List<string> toAdd = new List<string>{ "Dyscypliny indywidualne", "Dyscypliny zespołowe", "Trening", "Dyscypliny indywidualne drużynowe" };
                toAdd.ForEach(d => sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting(d).Split(new char[] { ';' })));
            }
            else
                sportDisciplineComboBox.Items.AddRange(TechnicalFunctions.getSetting(eventTypeComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));


            disableOtherGroupBoxes();
            setGradeNumericUpDownBrackets();

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void EventNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if(areAllEventFieldsValid() != "0")
            {
                MessageBox.Show("Błąd w polu " + areAllEventFieldsValid() + "!", "BŁAD KRYTYCZNY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (areAllChampionsFieldsValid() != "0" && getEventType() == "Dyscypliny indywidualne drużynowe")
            {
                MessageBox.Show("Błąd w polu " + areAllChampionsFieldsValid() + "!", "BŁAD KRYTYCZNY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Students.Count == 0)
            {
                MessageBox.Show("Błąd w polu UCZNIOWIE! Musisz dodać co najmniej jednego ucznia!", "BŁAD KRYTYCZNY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //var _Event = new KeyValuePair<string, DateTime>()
            Event _event = new Event(dbD.GetHighestId("wydarzenia") + 1, getEventName(), getEventDate());
            try
            {
                dbD.SetEvent(_event);
                MessageBox.Show("Pomyślnie dodano wydarzenie " + _event.name + " o id " + _event.id + " i dacie " + _event.date, "DODANO WYDARZENIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var logList = new List<Log>();
            //grade todo
            foreach(KeyValuePair<Student, int> pair in Students)
            {
                int points = 0;
                switch (getEventType())
                {
                    case "Dyscypliny indywidualne":
                        points = pc.calculatePoints(
                            getEventType(),
                            getIsRelay(),
                            getRelayCount(),
                            getPeopleCount(),
                            getIsChessOrSwimming(),
                            getPeopleCount(),
                            getPlayerPlace());
                        break;

                    case "Trening":
                        points = pc.calculatePoints(
                            getEventType());
                        break;

                    case "Organizacja":
                        points = pc.calculatePoints(
                            getEventType(),
                            false,
                            0,
                            0,
                            false,
                            0,
                            0,
                            getGradeForOrganization(),
                            getIsHigherRankEvent());
                        break;

                    case "Sędziowanie":
                        //TODO
                        break;

                    case "Dyscypliny zespołowe":
                        points = pc.calculatePoints(
                            getEventType(),
                            false,
                            0,
                            0,
                            false,
                            0,
                            getPlayerPlace(),
                            0,
                            false,
                            getTeamCount(),
                            getIsPingpongOrBadmintonOrRingoOrStreetballOrBridge(),
                            getMatchCount());
                        break;

                    case "Dyscypliny indywidualne drużynowe":
                        points = pc.calculatePoints(
                            getEventType(),
                            false,
                            0,
                            0,
                            false,
                            0,
                            0,
                            0,
                            false,
                            0,
                            false,
                            0,
                            getChampionsType());
                        break;
                }
                logList.Add(new Log(
                    dbD.GetHighestId("log") + 1,
                    dbD.GetStudentIdByParameters(pair.Key.name, pair.Key.surname, pair.Key.class_id),
                    points,
                    0, //todo punkty przechodnie
                    dbD.GetHighestId("wydarzenia")));
                dbD.InsertLog(logList.Last());

                if(TechnicalFunctions.getSetting("saveEventsToJSON").ToString() == bool.TrueString)
                {
                    KeyValuePair<Event, List<Log>> inserter = new KeyValuePair<Event, List<Log>>(_event, logList);
                    mm.WriteToFile(inserter);
                }

            }
            this.Close();
        }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            studentsToAddCheckedListBox.Items.Clear();
            var students = dbD.GetStudentsBySurname(getSurname());
            foreach (Student student in students)
                studentsToAddCheckedListBox.Items.Add(student.name + " " + student.surname + " " + dbD.GetClassById(student.class_id).name);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (getPlayerPlace() == -1)
                    return;
                List<string> selected = new List<string>();
                foreach(object itemChecked in studentsToAddCheckedListBox.CheckedItems)
                    selected.Add(itemChecked.ToString());
                string[] separated = selected[0].Split(new char[] { ' ' });
                Student student = dbD.GetStudentByNameAndSurname(separated[0], separated[1]);
                Students.Add(new KeyValuePair<Student, int>(student, getPlayerPlace()));
                addedStudentsCheckedListBox.Items.Add(student.name + " " + student.surname + " " + dbD.GetClassById(student.class_id).name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPRAWDŹ DANE! \n" + ex.Message, "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
         {
            try
            {
                List<string> selected = new List<string>();
                foreach (object itemChecked in addedStudentsCheckedListBox.CheckedItems)
                    selected.Add(itemChecked.ToString());
                string[] separated = selected[0].Split(new char[] { ' ' });
                Student student = dbD.GetStudentByNameAndSurname(separated[0], separated[1]);
                //var s = new Student(student.id, student.name, student.surname, student.class_id, student.sex);
                //var found = Students.Where(x => x.Key == student);
                KeyValuePair<Student, int> pair = new KeyValuePair<Student, int>(new Student(student.id, student.name, student.surname, student.class_id, student.sex), TechnicalFunctions.GetStudentsPlaceByStudent(Students, new Student(student.id, student.name, student.surname, student.class_id, student.sex)));
                var _students = new List<KeyValuePair<Student, int>>(Students);
                Students.Clear();
                Students = TechnicalFunctions.RemoveStudentFromList(_students, student);
                
                addedStudentsCheckedListBox.Items.Clear();
                foreach(KeyValuePair<Student, int> p in Students)
                    addedStudentsCheckedListBox.Items.Add(p.Key.name + " " + p.Key.surname + " " + dbD.GetClassById(p.Key.class_id).name);
                //var allItems = addedStudentsCheckedListBox.Items.OfType<string>().ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            deleteStudentButton.Enabled = false;
        }

        private void StudentNameTextBox_Click(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text == "Wprowadź nazwisko")
                studentNameTextBox.Text = String.Empty;
        }

        private void IsRelayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isRelayCheckBox.Checked)
                relayCountNumericUpDown.Enabled = true;
            else
                relayCountNumericUpDown.Enabled = false;
        }


        //getting main event info
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
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                eventNameTextBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }

        public string getEventType()
        {
            if(eventTypeComboBox.SelectedIndex > -1)
            {
                return eventTypeComboBox.SelectedItem.ToString();
            }
            else
            {
                eventTypeComboBox.BackColor = Color.Red;
                MessageBox.Show("WYBIERZ POPRAWNY TYP WYDARZENIA", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                eventTypeComboBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }

        private string getDiscipline()
        {
            if (sportDisciplineComboBox.SelectedIndex > -1)
                return sportDisciplineComboBox.Text.ToString();
            else
            {
                //sportDisciplineComboBox.BackColor = Color.Red;
                //MessageBox.Show("WYBIERZ POPRAWNĄ DYSCYPLINĘ", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                //sportDisciplineComboBox.BackColor = Color.Empty;
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
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                eventDateTimePicker.BackColor = Color.Empty;
                return new DateTime(1939, 9, 1, 4, 48, 0);
            }
        }

        

        //getting main student info
        private string getSurname()
        {
            if(studentNameTextBox.Text != "Wprowadź nazwisko")
            {
                return studentNameTextBox.Text.ToString();
            }
            else
            {
                studentNameTextBox.BackColor = Color.Red;
                MessageBox.Show("WPROWADŹ POPRAWNE NAZWISKO", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                studentNameTextBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }

        private int getPlayerPlace()
        {
            if(getEventType() == "Organizacja" || getEventType() == "Trening" || getEventType() == "Sędziowanie")
            {
                return 0;
            }
            else if(playerPlaceNumericUpDown.Value != 0)
            {
                try
                {
                    return Convert.ToInt32(playerPlaceNumericUpDown.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
            else
            {
                playerPlaceNumericUpDown.BackColor = Color.Red;
                MessageBox.Show("WPROWADŹ POPRAWNE MIEJSCE ZAWODNIKA", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                playerPlaceNumericUpDown.BackColor = Color.Empty;
                return -1;
            }
        }

        private bool getIsRelay()
        {
            return isRelayCheckBox.Checked;
        }

        private int getRelayCount()
        {
            if (getIsRelay())
            {
                try
                {
                    return Convert.ToInt32(relayCountNumericUpDown.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 0;
        }

        private int getPeopleCount()
        {
            try
            {
                return Convert.ToInt32(peopleCountNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        private string getChampionsType()
        {
            if(championsTypeComboBox.SelectedIndex > -1)
            {
                return championsTypeComboBox.SelectedItem.ToString();
            }
            else
            {
                championsTypeComboBox.BackColor = Color.Red;
                MessageBox.Show("WYBIERZ POPRAWNY TYP MISTRZOSTW", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(Convert.ToInt32(TechnicalFunctions.getSetting("waitAfterError")));
                championsTypeComboBox.BackColor = Color.Empty;
                return "WPROWADŹ WARTOŚĆ";
            }
        }

        private int getMatchCount()
        {
            try
            {
                return Convert.ToInt32(matchCountNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        private int getTeamCount()
        {
            try
            {
                return Convert.ToInt32(teamCountNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        private bool getIsHigherRankEvent()
        {
            return higherRankEventCheckBox.Checked;
        }

        private bool getIsLogging()
        {
            return loggingCheckBox.Checked;
        }

        private int getGradeForOrganization()
        {
            try
            {
                Convert.ToInt32(gradeForOrganizationNumericUpDown.Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        private bool getIsChessOrSwimming()
        {
            if (getDiscipline() == "Szachy" || getDiscipline() == "Pływanie")
                return true;
            else
                return false;
        }

        private bool getIsPingpongOrBadmintonOrRingoOrStreetballOrBridge()
        {
            if (getDiscipline() == "Ping pong" || getDiscipline() == "Streetball" || getDiscipline() == "Brydż" || getDiscipline() == "Badminton" || getDiscipline() == "Ringo")
                return true;
            else
                return false;
        }

        private string areAllEventFieldsValid()
        {
            if (eventNameTextBox.Text == "Nazwa wydarzenia" || eventNameTextBox.Text == "")
                return "NAZWA WYDARZENIA";
            else
                if (eventTypeComboBox.SelectedIndex < 0)
                    return "TYP WYDARZENIA";
                else
                    if (sportDisciplineComboBox.SelectedIndex < 0)
                        return "DYSCYPLINA";
                    else
                        return "0";
        }

        private string areAllChampionsFieldsValid()
        {
            if (championsTypeComboBox.SelectedItem == null)
                return "TYP MISTRZOSTW";
            return "0";
        }

        private void disableOtherGroupBoxes()
        {
            switch (eventTypeComboBox.SelectedItem)
            {
                case "Dyscypliny indywidualne":
                    individualSportsGroupBox.Enabled = true;
                    organizationGroupBox.Enabled = false;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = true;
                    break;
                case "Dyscypliny zespołowe":
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = false;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = true;
                    playerPlaceNumericUpDown.Enabled = true;
                    break;
                case "Dyscypliny indywidualne drużynowe":
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = false;
                    teamIndividualSportsGroupBox.Enabled = true;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = true;
                    break;
                case "Organizacja":
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = true;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = false;
                    break;
                case "Trening":
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = false;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = false;
                    break;
                case "Sędziowanie":
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = true;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = false;
                    break;
                default:
                    individualSportsGroupBox.Enabled = false;
                    organizationGroupBox.Enabled = false;
                    teamIndividualSportsGroupBox.Enabled = false;
                    teamSportsGroupBox.Enabled = false;
                    playerPlaceNumericUpDown.Enabled = true;
                    break;
            }
        }


        private void StudentsToAddCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < studentsToAddCheckedListBox.Items.Count; i++)
                if (i != e.Index)
                    studentsToAddCheckedListBox.SetItemChecked(i, false);
        }

        private void StudentsToAddCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddedStudentsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
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

        private void LoggingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setGradeNumericUpDownBrackets();
        }

        private void HigherRankEventCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setGradeNumericUpDownBrackets();
        }

        private void setGradeNumericUpDownBrackets()
        {
            if(getEventType() == "Sędziowanie")
            {
                loggingCheckBox.Enabled = true;
                if (!getIsLogging())
                {
                    if (getIsHigherRankEvent()) 
                    {
                        
                        gradeForOrganizationNumericUpDown.Minimum = 6;
                        gradeForOrganizationNumericUpDown.Maximum = 12;
                        gradeForOrganizationNumericUpDown.Value = 6;
                    }
                    else if(!getIsHigherRankEvent() && (getDiscipline() == "Badminton" || getDiscipline() == "Ringo" || getDiscipline() == "Ping pong"))
                    {
                        
                        gradeForOrganizationNumericUpDown.Minimum = 1;
                        gradeForOrganizationNumericUpDown.Maximum = 3;
                        gradeForOrganizationNumericUpDown.Value = 1;
                    }
                    else if ((getEventType() == "Dyscypliny zespołowe" && getDiscipline() == "Badminton" && getDiscipline() == "Ringo" && getDiscipline() == "Ping pong") || getDiscipline() == "Pływanie")
                    {
                        
                        gradeForOrganizationNumericUpDown.Minimum = 1;
                        gradeForOrganizationNumericUpDown.Maximum = 6;
                        gradeForOrganizationNumericUpDown.Value = 1;
                    }
                }
                else
                {
                    if (getIsHigherRankEvent())
                    {
                        
                        gradeForOrganizationNumericUpDown.Minimum = 1;
                        gradeForOrganizationNumericUpDown.Maximum = 3;
                        gradeForOrganizationNumericUpDown.Value = 1;
                    }
                    else
                    {
                        
                        gradeForOrganizationNumericUpDown.Minimum = 3;
                        gradeForOrganizationNumericUpDown.Maximum = 6;
                        gradeForOrganizationNumericUpDown.Value = 3;
                    }
                }
            }
            else if(getEventType() == "Organizacja")
            {
                loggingCheckBox.Enabled = false;
                
                gradeForOrganizationNumericUpDown.Minimum = 5;
                gradeForOrganizationNumericUpDown.Maximum = 35;
                gradeForOrganizationNumericUpDown.Value = 5;
            }


        }

        private void addedStudentsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
