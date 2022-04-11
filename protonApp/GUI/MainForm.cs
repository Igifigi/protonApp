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
using protonApp.Data;
using Newtonsoft.Json;

// Convert.ToInt32(<stringVal>)

namespace protonApp
{
    
    public partial class MainForm : Form
    {
        TechnicalFunctions technicalFunctions = new TechnicalFunctions();
        public MainForm()
        {
            InitializeComponent();

            //ConnectionStringsForm csf = new ConnectionStringsForm();
            //csf.ShowDialog();
        }


        private void DirectQueryButton_Click(object sender, EventArgs e)
        {
            DirectDatabaseQueryForm dbq = new DirectDatabaseQueryForm();
            dbq.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //test();
            //update();
            // versionLabel.Text = "v." + TechnicalFunctions.getSetting("version");
            setVersion();
        }
        //private void test()
        //{

        //    Console.WriteLine(JsonConvert.SerializeObject(""));
        //}

        private void EventsButton_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();
            eventsForm.ShowDialog();
        }

        private void setVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            versionLabel.Text = "v." + fileVersionInfo.FileVersion.ToString();

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

        private void rankingButton_Click(object sender, EventArgs e)
        {
            RankingForm rankingForm = new RankingForm();
            rankingForm.ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void SubmitIssueButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Igifigi/protonApp/issues");
        }
    }
}
