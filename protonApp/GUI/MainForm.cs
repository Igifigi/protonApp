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

// Convert.ToInt32(<stringVal>)

namespace protonApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void DirectQueryButton_Click(object sender, EventArgs e)
        {
            DirectDatabaseQueryForm dbq = new DirectDatabaseQueryForm();
            dbq.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            test();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();
            eventsForm.ShowDialog();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    List<Klasy> test = testsql();
        //    string str = "";

        //    for(int i = 0; i < test.Count; i++)
        //    {
        //        str += "Id: " + test[i].Id + ", nazwa: " + test[i].Nazwa + ", punkty: " + test[i].Punkty + "\n";
        //    }
        //    label2.Text = str;
        //}

        //private List<Klasy> testsql()
        //{
        //    string connectionData = "datasource=127.0.0.1;port=3306;username=root;password=;database=proton";
        //    MySqlConnection connectionSQL = new MySqlConnection(connectionData);
        //    connectionSQL.Open();
        //    MySqlCommand commandSQL = new MySqlCommand("select * from klasy", connectionSQL);
        //    DataTable tableSQL = new DataTable();
        //    MySqlDataReader readerSQL = commandSQL.ExecuteReader();

        //    List <Klasy> klasy = new List<Klasy>();

        //    while (readerSQL.Read())
        //    {
        //        Klasy klasa = new Klasy();
        //        klasa.Id = Convert.ToInt32(readerSQL["Id"]);
        //        klasa.Nazwa = Convert.ToString(readerSQL["Nazwa"]);
        //        klasa.Punkty = Convert.ToInt32(readerSQL["Punkty"]);
        //        klasy.Add(klasa);
        //    }
        //    readerSQL.Close();

        //    return klasy;
        //}

        private void test()
        {
            //    string sAttr;
            //    string xdw;

            //    //xdw = ConfigurationManager.AppSettings.Get("TESTstring");
            //    //int x = Convert.ToInt32(sAttr);
            //    //x++;
            //    List<string> k = new List<string>(ConfigurationManager.AppSettings.AllKeys);
            //    //List<string> w = new List<string>(ConfigurationManager.AppSettings["testList"].Split(new char[] { ';' }));

            //    //Console.WriteLine();
            //    //for (int i = 0; i < w.Count; i++)
            //    //    Console.WriteLine(w[i]);

            //    Console.WriteLine();
            //    for (int i = 0; i < k.Count; i++)
            //        Console.WriteLine(k[i]);




            PointsCalculator pointsCalculator = new PointsCalculator();
            //pointsCalculator.calculatePoints(

        }




        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void studnetsButton_Click(object sender, EventArgs e)
        {
            StudentsListForm studentsListForm = new StudentsListForm();
            studentsListForm.ShowDialog();
        }
    }
}
