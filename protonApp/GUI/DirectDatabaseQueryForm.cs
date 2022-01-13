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
using protonApp.Data;
using protonApp.Logic;

namespace protonApp.GUI
{
    public partial class DirectDatabaseQueryForm : Form
    {
        OtherDatabaseModifications md = new OtherDatabaseModifications();
        public DirectDatabaseQueryForm()
        {
            InitializeComponent();
            if (MessageBox.Show("Uwaga! Korzystasz z tej opcji na własną odpowiedzialność! Nie działa ona poprawnie i NIE będzie rozwijana. Prosimy mieć na względzie, iż jeden zły znak może zepsuć całą bazę! Czy na pewno chcesz przejść dalej?", "UWAGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                Application.ExitThread();
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
