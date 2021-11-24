using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Corp_InterCable
{
    internal class ConectorBD
    {
        
        public static SqlConnection ConnectToDB()
        {
            string db = "Server=LAPTOP-LQT2J27K\\SQLEXPRESS; DataBase=InterCable; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(db);
            return conn;
        }
    }
}
