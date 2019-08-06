using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Managementul_Hotelurilor.Entities
{
    class Hotels
    {
        public int Hotel_ID { get; }
        public string Hotel_Name { get; }
        public int Location { get; }
        /// <summary>
        /// Constructor for a new Hotels element
        /// </summary>
        /// <param name="Hotel_ID"></param>
        /// <param name="Hotel_Name"></param>
        /// <param name="Location"></param>
        public Hotels(int Hotel_ID, string Hotel_Name, int Location)
        {
            this.Hotel_ID = Hotel_ID;
            this.Hotel_Name = Hotel_Name;
            this.Location = Location;
        }
        public Hotels(ref Hotels H)
        {
            Hotel_ID = H.Hotel_ID;
            Hotel_Name = H.Hotel_Name;
            Location = H.Location;
        }
        public Hotels(OracleDataReader reader)
        {
            Hotel_ID = Int32.Parse(reader["Hotel_ID"].ToString());
            Hotel_Name = reader["Hotel_Name"].ToString();
            Location = Int32.Parse(reader["Location"].ToString());
        }
    }
}
