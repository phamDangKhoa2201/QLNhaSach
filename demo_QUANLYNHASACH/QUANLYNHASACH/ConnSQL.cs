using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUANLYNHASACH
{
    class ConnSQL
    {
        public static string srvName = @"HP090123\SQLEXPRESS";
        public static string dbName = "QL_NHASACH";
        public SqlConnection KetNoiCSDL()
        {
            string stringconn = "Data Source=" + srvName + "; Initial Catalog =" + dbName + "; Integrated Security = True";
            SqlConnection conn = new SqlConnection(stringconn);
            return conn;
        }
    }
}
