using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using protonApp.Model;
using protonApp.Data;

namespace protonApp.Logic
{
    class DatabaseDownloader
    {
        MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
        internal List<Student> GetStudents()
        {
            List<Student> result = new List<Student>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from uczniowie", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Student(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Imie"].ToString(),
                        sqlDataReader["Nazwisko"].ToString(),
                        Convert.ToInt32(sqlDataReader["Klasa_Id"]),
                        Convert.ToInt32(sqlDataReader["Plec"])
                        ));
                }
                sqlDataReader.Close();

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public List<Event> GetEvents()
        {
            List<Event> result = new List<Event>();
            MySqlCommand sqlCommand = new MySqlCommand("select * from wydarzenia", sqlConnection);
            try
            {
                sqlConnection.Open();
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    result.Add(new Event(
                        Convert.ToInt32(sqlDataReader["Id"]),
                        sqlDataReader["Nazwa"].ToString(),
                        Convert.ToDateTime(sqlDataReader["Data"])
                        ));
                }
                sqlDataReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

    }
}
