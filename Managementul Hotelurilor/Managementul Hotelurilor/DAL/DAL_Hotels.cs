using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    class DAL_Hotels
    {
        public Dictionary<int, string> HotelsDictionary { get; }
        public DAL_Hotels(int ID)
        {
            HotelsDictionary = GetHotel(ID);
        }
        private Dictionary<int,string> GetHotel(int ID)
        {

            Dictionary<int, string> LocalDictionary = new Dictionary<int, string>();
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter OA = new OracleDataAdapter("Select_Hotels", conn))
                {
                    OA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = System.Data.ParameterDirection.Output;

                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "loc_id";
                    OP1.OracleDbType = OracleDbType.Int32;
                    OP1.Direction = System.Data.ParameterDirection.Input;
                    OP1.Value = ID;

                    OA.SelectCommand.Parameters.Add(OP);
                    OA.SelectCommand.Parameters.Add(OP1);

                    DataTable City_table = new DataTable();
                    OA.Fill(City_table);

                    foreach (DataRow row in City_table.Rows)
                    {
                        LocalDictionary.Add(Int32.Parse(row["IdHotel"].ToString()), row["Nume Hotel"].ToString());
                    }
                    return LocalDictionary;
                }
            }
        }

        public static int GetHotelID(string s, Dictionary<int,string> keyValuePairs)
        {
            foreach(KeyValuePair<int,string> kV in keyValuePairs)
            {
                if (kV.Value == s)
                    return kV.Key;
            }
            return 0;
        }
    }
}
