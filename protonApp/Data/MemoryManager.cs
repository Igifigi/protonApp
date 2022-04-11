using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace protonApp.Data
{
    class MemoryManager
    {
        static readonly string cache_directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + @"\Proton";
        readonly string connection_string_path = cache_directory + @"\connection_data.json";

        #region Directory managment
        private void GenerateEmptyDirectory()
        {
            Directory.CreateDirectory(cache_directory);
        }

        private void GenerateEmptyConnectionStringPathFile()
        {
            File.Create(connection_string_path);
            File.WriteAllText(connection_string_path, JsonConvert.SerializeObject("datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True"));
        }
        #endregion

        #region Connection String
        public string GetConnectionString()
        {
            if (!Directory.Exists(cache_directory))
                GenerateEmptyDirectory();
            if (!File.Exists(connection_string_path))
                GenerateEmptyConnectionStringPathFile();
            try
            {
                return JsonConvert.DeserializeObject<string>(File.ReadAllText(connection_string_path));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać zawartości pamięci cache!\n" + ex.Message, "BŁAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return String.Empty;
        }

        public void SetConnectionString(string s)
        {
            if (!Directory.Exists(cache_directory))
                GenerateEmptyDirectory();
            if (!File.Exists(connection_string_path))
                GenerateEmptyConnectionStringPathFile();
            try
            {
                File.WriteAllText(connection_string_path, JsonConvert.SerializeObject(s));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać zawartości pamięci cache!\n" + ex.Message, "BŁAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
