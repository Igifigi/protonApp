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
    public partial class StudentEditForm : Form
    {
        OtherDatabaseModifications mf = new OtherDatabaseModifications();
        DatabaseDownloader dw = new DatabaseDownloader();
        int id=0;
        public StudentEditForm(int i)
        {
            id = i;
            InitializeComponent();
            initializeComboBoxes();
            initializeStudent();
        }
        private void initializeStudent()
        {

        Student student = dw.GetStudentById(id);
            textBox1.Text = (string)student.name;
            textBox2.Text = (string)student.surname;
            Console.WriteLine(student.sex);
            if(student.sex == 1)menRadioButton.Checked = true;
            else womenRadioButton.Checked = true;
            selectClassComboBox.SelectedIndex = student.class_id-1;
        }
        private void initializeComboBoxes()
        {
            List<Class> classes = dw.GetClasses();
            for (int i = 0; i < classes.Count; i++)
            {
                selectClassComboBox.Items.Add(classes[i].name);
            }

        }
        private void editStudent_Click(object sender, EventArgs e)
        {
            string text = "UPDATE `uczniowie` SET `Imie`='" + textBox1.Text + "',`nazwisko`='" + textBox2.Text + "',`klasa_id`=" + dw.GetClassIdByName(selectClassComboBox.SelectedItem.ToString()) + ",`plec`=" + getSex() + " where Id=" + id;
            mf.sendDirectQuery(text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
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
