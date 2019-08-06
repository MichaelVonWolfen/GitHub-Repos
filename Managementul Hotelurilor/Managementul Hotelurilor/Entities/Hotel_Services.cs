using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Managementul_Hotelurilor.Entities
{
    class Hotel_Services
    {
        public int Hotel_Services_ID { get; }
        public string Description { get; }
        public string Type { get; }
        public char Is_active { get; }
        public DateTime CreatedOn { get; }
        public string Created_by{get;}
        public DateTime UpdatedOn { get; }
        public string UpdatedBy { get; }
        public int Hotel_ID { get; }

        public Hotel_Services(int Hotel_Services_ID, string Description, string Type, char Is_active, DateTime CreatedOn, string Created_by, DateTime UpdatedOn, string UpdatedBy,int Hotel_ID )
        {
            this.Hotel_Services_ID = Hotel_Services_ID;
            this.Hotel_ID = Hotel_ID;
            this.Description = Description;
            this.Type = Type;
            this.Is_active = Is_active;
            this.CreatedOn = CreatedOn;
            this.Created_by = Created_by;
            this.UpdatedBy = UpdatedBy;
            this.UpdatedOn = UpdatedOn;
        }
        public Hotel_Services(OracleDataReader reader)
        {
            Hotel_Services_ID = Int32.Parse(reader["Hotel_Services_ID"].ToString());
            Description = reader["Description"].ToString();
            Type = reader["Type"].ToString();
            Is_active = char.Parse(reader["Is_active"].ToString());
            CreatedOn = DateTime.Parse(reader["CreatedOn"].ToString());
            Created_by = reader["Created_by"].ToString();
            UpdatedOn = DateTime.Parse(reader["UpdatedOn"].ToString());
            UpdatedBy = reader["UpdatedBy"].ToString();
            Hotel_ID = Int32.Parse(reader["Hotel_ID"].ToString());
        }
    }
}
