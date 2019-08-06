using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Managementul_Hotelurilor.DAL
{
    class DatabaseConection
    {
        public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings["StoicaMihai"].ConnectionString;
                OracleConnectionStringBuilder sb = new OracleConnectionStringBuilder(connStr);
                return sb.ToString();
            }
        }
        public static OracleConnection GetOracleConnection()
        {
            OracleConnection conn = new OracleConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
