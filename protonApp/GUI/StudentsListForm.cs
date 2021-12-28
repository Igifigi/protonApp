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
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
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
    }
}
