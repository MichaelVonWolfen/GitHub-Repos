using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Managementul_Hotelurilor.Entities
{
    class Country
    {
        public int Country_id { get; }
        public string Country_Name { get; }
        public Country(int Country_id, string Country_Name)
        {
            this.Country_id = Country_id;
            this.Country_Name = Country_Name;
        }
        public Country(OracleDataReader reader)
        {
            Country_id = Int32.Parse(reader["Country_id"].ToString());
            Country_Name = reader["Country_Name"].ToString();
        }
    }
}
