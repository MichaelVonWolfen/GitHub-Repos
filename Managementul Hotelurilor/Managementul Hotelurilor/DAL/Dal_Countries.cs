using Managementul_Hotelurilor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Managementul_Hotelurilor.DAL
{
    class Dal_Countries
    {
        public List<Country> CountriesList;
        public Country country;
        public static void GetCountries()
        {
            using(OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter da = new OracleDataAdapter("Select_Countries", conn)
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                }
            }
        }
    }
}
