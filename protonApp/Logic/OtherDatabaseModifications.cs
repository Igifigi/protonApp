using MySql.Data.MySqlClient;
using protonApp.Data;
using System;

namespace protonApp.Logic
{
    internal class OtherDatabaseModifications
    {
        public void sendDirectQuery(string text)
        {
            MySqlConnection sqlConnection = DatabaseConnectionData.sqlConnection;
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




        }
    }
}
