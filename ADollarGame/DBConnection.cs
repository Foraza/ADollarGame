using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ADollarGame
{
    class DBConnection
    {
        static private MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=final_project;port=3308;password=root");
        
        static public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
