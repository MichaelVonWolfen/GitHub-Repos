using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.Entities
{
    class Locations
    {
        public int Location_ID { get; }
        public string City_Name { get; }
        public int Country_ID { get; }
        public Locations(int Location_ID, string City_Name, int Country_ID)
        {
            this.City_Name = City_Name;
            this.Country_ID = Country_ID;
            this.Location_ID = Location_ID;
        }
        public Locations(OracleDataReader reader)
        {
            Location_ID = Int32.Parse(reader["Location_ID"].ToString());
            City_Name = reader["City"].ToString();
            Country_ID = Int32.Parse(reader["Country_ID"].ToString());
        }
    }
}
