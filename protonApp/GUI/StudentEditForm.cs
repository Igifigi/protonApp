//using protonApp.Logic;
//using protonApp.Model;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace protonApp.GUI
//{
//    public partial class StudentEditForm : Form
//    {
//        OtherDatabaseModifications mf=new OtherDatabaseModifications();
//        DatabaseDownloader dw = new DatabaseDownloader();
//        Student student = null;

//        public StudentEditForm(Student std)
//        {
//            InitializeComponent();
//            initializeComboBoxes();
//        }
//        private void initializeComboBoxes()
//        {
//            List<Class> classes = dw.GetClasses();
//            for (int i = 0; i < classes.Count; i++)
//            {
//                selectClassComboBox.Items.Add(classes[i].name);
//            }
//            //selectClassComboBox.Items.AddRange(databaseDownloader.GetClasses().ToArray());
//        }
//        private void editStudent_Click(object sender, EventArgs e)
//        {
//           string text =  "Update 'uczniowie' set 'Imie'='"+textBox1.Text+"','nazwisko'='"+textBox2.Text+"','klasa_id'="+dw.GetClassIdByName(selectClassComboBox.ToString())+"'plec'="+getSex()+" where Id=" + dw.GetStudentIdByParameters(student.name,student.surname,student.class_id );
//            mf.sendDirectQuery(text);
//            this.Close();
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void radioButton1_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void radioButton2_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//        private bool getSex()
//        {
//            if (menRadioButton.Checked)
//                return true;
//            else if (womenRadioButton.Checked)
//                return false;
//            else
//                return false;
//        }
//    }
//}
