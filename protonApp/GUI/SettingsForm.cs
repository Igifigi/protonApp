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

namespace protonApp.GUI
{
    public partial class SettingsForm : Form
    {
        TechnicalFunctions technicalFunctions = new TechnicalFunctions();

        

        public SettingsForm()
        {
            InitializeComponent();
            initializeComboBoxesAndButtons();
        }

        private void initializeComboBoxesAndButtons()
        {
            selectKeyComboBox.Items.AddRange((ConfigurationManager.AppSettings.AllKeys.ToArray()));
        }
        //private string[] translateToPolish(string[] input)
        //{
        //    string[] output = new string[input.Length];
        //    for(int i = 0; i < input.Length; i++)
        //    {
        //        switch (input[i])
        //        {
        //            case "eventType":
        //                output[i] =  "Typ wydarzeń";
        //                break;
        //            case "sportDiscipline":
        //                output[i] = "Dyscypliny";
        //                break;
        //            default:
        //                output[i] = "BŁĄD ODCZYTU";
        //                break;
        //            //tu w case'ach dodawaj rzeczy z configu
        //        }
        //    }
        //    return output;
        //}

        

        private void SelectKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectValueComboBox.Items.Clear();
            selectValueComboBox.Items.AddRange(TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).Split(new char[] { ';' }));
        }

        //TODO: add, edit i delete


        private void AddValueButton_Click(object sender, EventArgs e)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //config.AppSettings.Settings[key].Value = value;
            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //config.AppSettings.Settings[selectKeyComboBox.SelectedItem.ToString()].Value = ";" + insertValueTextBox.Text;
            //config.Save(ConfigurationSaveMode.Full, true);
            //ConfigurationManager.RefreshSection("appSettings");
            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings[selectKeyComboBox.SelectedItem.ToString()].Value = ";" + insertValueTextBox.Text;
            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).Save(ConfigurationSaveMode.Full, true);
            //ConfigurationManager.RefreshSection("appSettings");
            
            TechnicalFunctions.setSetting(selectKeyComboBox.SelectedItem.ToString(), TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString() + ";" + insertValueTextBox.Text));
        }

        private void EditValueButton_Click(object sender, EventArgs e)
        {
            string si = selectKeyComboBox.SelectedItem.ToString();
            string toedit = selectValueComboBox.SelectedItem.ToString();
            string accVal = TechnicalFunctions.getSetting(si);
            int delCount = accVal.IndexOf(toedit);
            string value = accVal.Remove(delCount - 1, toedit.Length);
            //TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).re selectValueComboBox.SelectedItem.ToString()
            TechnicalFunctions.setSetting(si, value + ";" + insertValueTextBox.Text);
        }

        private void DeleteValueButton_Click(object sender, EventArgs e)
        {
            string si = selectKeyComboBox.SelectedItem.ToString();
            string toedit = selectValueComboBox.SelectedItem.ToString();
            string accVal = TechnicalFunctions.getSetting(si);
            int delCount = accVal.IndexOf(toedit);
            string value = accVal.Remove(delCount - 1, toedit.Length);
            //TechnicalFunctions.getSetting(selectKeyComboBox.SelectedItem.ToString()).re selectValueComboBox.SelectedItem.ToString()
            TechnicalFunctions.setSetting(si, value);
        }

        private void ResetValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalFunctions.setSetting(selectKeyComboBox.SelectedItem.ToString(), TechnicalFunctions.GetValueByKey(StaticSettingsData.data, selectKeyComboBox.SelectedItem.ToString()));
                MessageBox.Show("Pomyślnie zresetowano klucz " + selectKeyComboBox.SelectedItem.ToString(), "Proton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void ConnectionStringsFormButton_Click(object sender, EventArgs e)
        {
            ConnectionStringsForm csf = new ConnectionStringsForm();
            csf.ShowDialog();
        }

        private void DirectDatabaseQueryButton_Click(object sender, EventArgs e)
        {
            DirectDatabaseQueryForm ddqf = new DirectDatabaseQueryForm();
            ddqf.ShowDialog();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void developerToolsFormButton_Click(object sender, EventArgs e)
        {
            DeveloperToolsForm dtF = new DeveloperToolsForm();
            dtF.ShowDialog();
        }
    }
}
