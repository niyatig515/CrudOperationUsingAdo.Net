using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace StudentRepository
{
    public class Connection
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }
        public static void OpenConnection(SqlConnection con)
        {
           con.Open();
        }
        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }
    }
}
