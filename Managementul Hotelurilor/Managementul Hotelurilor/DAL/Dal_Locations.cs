using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Managementul_Hotelurilor.DAL
{
    class Dal_Locations
    {
        /// <summary>
        /// Location == city
        /// </summary>
        public Dictionary<int,string> LocationDictionary
        {
            get;
        }
        public Dal_Locations(int ID)
        {
            LocationDictionary = GetLocations(ID);
        }
        private Dictionary<int,string> GetLocations(int ID)
        {
            Dictionary<int, string> LocalDictionary = new Dictionary<int, string>();

            using(OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter OA = new OracleDataAdapter("Select_Locations",conn))
                {
                    OA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = System.Data.ParameterDirection.Output;

                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "c_ID";
                    OP1.OracleDbType = OracleDbType.Int32;
                    OP1.Direction = System.Data.ParameterDirection.Input;
                    OP1.Value = ID;

                    OA.SelectCommand.Parameters.Add(OP);
                    OA.SelectCommand.Parameters.Add(OP1);

                    DataTable City_table = new DataTable();
                    OA.Fill(City_table);

                    foreach(DataRow row in City_table.Rows)
                    {
                        LocalDictionary.Add(Int32.Parse(row["Location_ID"].ToString()), row["Location_Name"].ToString());
                    }
                    return LocalDictionary;
                }
            }

            
        }
        /// <summary>
        /// Returns the Id of the selected city in a combobox
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetLocationID(string s, Dictionary<int, string> Locations)
        {
            foreach(KeyValuePair<int,string> keyValuePair in Locations)
            {
                if (keyValuePair.Value == s)
                    return keyValuePair.Key;
            }
            return 0;
        }
    }
}
