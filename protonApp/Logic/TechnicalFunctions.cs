using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using protonApp.Model;
using protonApp.Logic;

namespace protonApp.Data
{
    public class TechnicalFunctions
    {
        //DatabaseDownloader dd = new DatabaseDownloader();

        internal  void setSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");



            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings[key].Value = value;
            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).Save(ConfigurationSaveMode.Full, true);
            
        }
        internal  string getSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        internal  string getConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
        internal  void setConnectionString(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        internal  bool HasSpace(string s)
        {
            foreach(char c in s)
            {
                if (c == ' ') return true;
            }
            return false;
        }
        internal  int GetStudentsPlaceByStudent(List<KeyValuePair<Student, int>> list, Student student)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].Key.id == student.id)
                    return list[i].Value;
            return 0;
        }
        internal  List<KeyValuePair<Student, int>> RemoveStudentFromList(List<KeyValuePair<Student, int>> list, Student student)
        {
            var result = new List<KeyValuePair<Student, int>>();
            foreach (KeyValuePair<Student, int> pair in list)
                if (pair.Key.id != student.id)
                    result.Add(pair);
            return result;
        }
        internal  string GetValueByKey(List<KeyValuePair<string, string>> list, string key)
        {
            foreach(var o in list)
                if (o.Key == key)
                    return o.Value;
            return String.Empty;
        }
        internal List<string> SplitStringIntoNameAndSurname(string s)
        {
            return Regex.Split(s, @"()\w+").ToList();
        }
        internal string ConvertCSharpDateTimeToMySqlDateTime(DateTime dt)
        {
            return dt.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
        }

        internal List<string> ConvertToStringList(ListBox listBox)
        {
            List<string> result = new List<string>();
            foreach (var item in listBox.Items)
                result.Add(item.ToString());
            return result;
        }


    }
}
