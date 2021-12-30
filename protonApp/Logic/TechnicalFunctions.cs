﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace protonApp.Data
{
    class TechnicalFunctions
    {
        internal static void setSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");



            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings[key].Value = value;
            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).Save(ConfigurationSaveMode.Full, true);
            
        }
        internal static string getSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        internal static bool HaveSpace(string s)
        {
            foreach(char c in s)
            {
                if (c == ' ') return true;
            }
            return false;
        }
        internal List<string> SplitStringIntoNameAndSurname(string s)
        {
            return Regex.Split(s, @"()\w+").ToList();
        }
    }
}
