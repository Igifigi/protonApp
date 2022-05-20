using MySql.Data.MySqlClient;
using System.Configuration;
using protonApp.Data;

namespace protonApp.Data
{
    public class DatabaseConnectionData
    {
        MemoryManager mm = new MemoryManager();
        //public static readonly string connectionData = m_m.GetConnectionString();
        
        public string GetConnectionData()
        {
            return mm.GetConnectionString();
        }

        //internal static readonly string connectionData = "server=localhost;user=root;database=protonapp;password=;";


        //internal static readonly MySqlConnection sqlConnection = new MySqlConnection(this.GetConnectionData());
        //readonly MySqlCommand downloadEventsData = new MySqlCommand("select * from wydarzenia", sqlConnection);

    }
}
