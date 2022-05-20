using MySql.Data.MySqlClient;
using System.Configuration;
using protonApp.Data;

namespace protonApp.Data
{
    public class DatabaseConnectionData
    {
        static MemoryManager m_m = new MemoryManager();
        internal static readonly string connectionData = m_m.GetConnectionString();

        //internal static readonly string connectionData = "server=localhost;user=root;database=protonapp;password=;";


        internal static readonly MySqlConnection sqlConnection = new MySqlConnection(connectionData);
        //readonly MySqlCommand downloadEventsData = new MySqlCommand("select * from wydarzenia", sqlConnection);

    }
}
