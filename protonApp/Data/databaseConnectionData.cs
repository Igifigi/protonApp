using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace protonApp.Data
{
    internal class DatabaseConnectionData
    {

        internal static readonly string connectionData =ConfigurationManager.ConnectionStrings["dbConfig"].ConnectionString;

        //internal static readonly string connectionData = "server=localhost;user=root;database=protonapp;password=;";


        internal static readonly MySqlConnection sqlConnection = new MySqlConnection(connectionData);
        //readonly MySqlCommand downloadEventsData = new MySqlCommand("select * from wydarzenia", sqlConnection);

    }
}
