using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    class Dal_Rooms
    {
        public static DataTable GetRooms(int ID)
        {

            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter OA = new OracleDataAdapter("Select_Rooms2", conn))
                {
                    OA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = System.Data.ParameterDirection.Output;

                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "H_Id";
                    OP1.OracleDbType = OracleDbType.Int32;
                    OP1.Direction = System.Data.ParameterDirection.Input;
                    OP1.Value = ID;

                    OA.SelectCommand.Parameters.Add(OP1);
                    OA.SelectCommand.Parameters.Add(OP);

                    DataTable City_table = new DataTable();
                    OA.Fill(City_table);

                    return City_table;
                }
            }
        }
        public static DataTable GetOcupiedRooms(string StoreProcedureName)
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter OA = new OracleDataAdapter(StoreProcedureName, conn))
                {
                    OA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = System.Data.ParameterDirection.Output;

                    OA.SelectCommand.Parameters.Add(OP);

                    DataTable Filed_Rooms = new DataTable();
                    OA.Fill(Filed_Rooms);

                    return Filed_Rooms;
                }
            }
        }
    }
}
