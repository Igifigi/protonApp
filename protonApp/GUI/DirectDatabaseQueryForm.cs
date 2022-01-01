using protonApp.Logic;
using System;
using System.Windows.Forms;

namespace protonApp.GUI
{
    public partial class DirectDatabaseQueryForm : Form
    {
        OtherDatabaseModifications md = new OtherDatabaseModifications();
        public DirectDatabaseQueryForm()
        {
            InitializeComponent();
            chooseQueryMethodComboBox.Items.Add("SELECT");
            chooseQueryMethodComboBox.Items.Add("INSERT, UPDATE, DELETE");
            chooseQueryMethodComboBox.Items.Add("SELECT (*)");
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            md.sendDirectQuery(queryTextbox.Text);
        }

        //private short transfer()
        //{
        //    if(chooseQueryMethodComboBox.SelectedIndex)
        //}



        private void DirectDatabaseQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
