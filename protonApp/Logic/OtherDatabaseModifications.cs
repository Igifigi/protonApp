using MySql.Data.MySqlClient;
using protonApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Logic
{
    public class OtherDatabaseModifications
    {

        Data.DatabaseConnectionData dbcd = new Data.DatabaseConnectionData();
        public void sendDirectQuery(string text)
        {
            MySqlConnection sqlConnection = new MySqlConnection(dbcd.GetConnectionData());
            MySqlCommand sendQuery = new MySqlCommand(text, sqlConnection);
            //MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();

            try
            {
                sqlConnection.Open();
                Console.WriteLine("connection established");
                Console.WriteLine("selected 'insert etc.' query");
                sendQuery.ExecuteNonQuery();

                sqlConnection.Close();



            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            sqlConnection.Close();

            //"\"datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True\""


        }
    }
}
