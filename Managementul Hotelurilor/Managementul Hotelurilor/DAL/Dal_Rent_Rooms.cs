using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    static class Dal_Rent_Rooms
    {
        /// <summary>
        /// Inserts the new rented room in the table designated them
        /// </summary>
        /// <param name="renter"></param>
        public static void InsertRenter(Entities.Rent_Rooms renter)
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleCommand OA = new OracleCommand("Make_Reservation", conn))
                {
                    OA.CommandType = CommandType.StoredProcedure;
                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "RoomID";
                    OP1.OracleDbType = OracleDbType.Int32;
                    OP1.Direction = System.Data.ParameterDirection.Input;
                    OP1.Value = renter.ROOM_ID;

                    OracleParameter OP2 = new OracleParameter();
                    OP2.ParameterName = "dateS";
                    OP2.OracleDbType = OracleDbType.Date;
                    OP2.Direction = System.Data.ParameterDirection.Input;
                    OP2.Value = renter.START_DATE;

                    OracleParameter OP3 = new OracleParameter();
                    OP3.ParameterName = "dateE";
                    OP3.OracleDbType = OracleDbType.Date;
                    OP3.Direction = System.Data.ParameterDirection.Input;
                    OP3.Value = renter.END_DATE;

                    OracleParameter OP4 = new OracleParameter();
                    OP4.ParameterName = "ReservID";
                    OP4.OracleDbType = OracleDbType.Varchar2;
                    OP4.Direction = System.Data.ParameterDirection.Input;
                    OP4.Value = renter.ReservationID;

                    OA.Parameters.Add(OP2);
                    OA.Parameters.Add(OP3);
                    OA.Parameters.Add(OP1);
                    OA.Parameters.Add(OP4);


                    OA.ExecuteNonQuery();

                }
            }
        }
    }
}
