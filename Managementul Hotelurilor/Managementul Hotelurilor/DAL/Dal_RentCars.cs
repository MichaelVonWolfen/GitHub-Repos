using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    class Dal_RentCars
    {
        public static List<Entities.RentCars> Rents{ get; set; }

        public  static void Get_Cars_Rent(int H_ID)
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter OA = new OracleDataAdapter("SelectRentCars", conn))
                {
                    OA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = System.Data.ParameterDirection.Output;

                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "ID_Hotel";
                    OP1.OracleDbType = OracleDbType.Int32;
                    OP1.Direction = System.Data.ParameterDirection.Input;
                    OP1.Value = H_ID;

                    OA.SelectCommand.Parameters.Add(OP);
                    OA.SelectCommand.Parameters.Add(OP1);

                    DataTable Cars_rent = new DataTable();
                    OA.Fill(Cars_rent);

                    Rents = new List<Entities.RentCars>();
                    Rents = (from DataRow dt in Cars_rent.Rows
                             select new Entities.RentCars()
                             {
                                 CAR_NAME_TYPE = dt["CarType"].ToString(),
                                 RENT_CARS_TYPE_ID = Int32.Parse(dt["RentID"].ToString()),
                                 RENT_PRICE = int.Parse(dt["RentPrice"].ToString()),
                                 HOTEL_ID = int.Parse(dt["HotelID"].ToString())
                             }).ToList();
                }
            }
        }
    }
}
