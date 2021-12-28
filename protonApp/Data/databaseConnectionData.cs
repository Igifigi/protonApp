using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace protonApp.Data
{
    internal class DatabaseConnectionData
    {
        static internal readonly string connectionData = "datasource=127.0.0.1;port=3306;username=root;password=;database=proton;convert zero datetime=True";

        static internal readonly MySqlConnection sqlConnection = new MySqlConnection(connectionData);
        //readonly MySqlCommand downloadEventsData = new MySqlCommand("select * from wydarzenia", sqlConnection);

    }
}
