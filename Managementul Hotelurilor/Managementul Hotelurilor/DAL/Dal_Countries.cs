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
        public static Dictionary<int, string> CountriesDictionary
        {
            get
            {
                return GetCountries();
            }
        }
        public static Dictionary<int, string> GetCountries()
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleDataAdapter da = new OracleDataAdapter("Select_Countries", conn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    OracleParameter OP = new OracleParameter();
                    OP.ParameterName = "S";
                    OP.OracleDbType = OracleDbType.RefCursor;
                    OP.Direction = ParameterDirection.Output;

                    da.SelectCommand.Parameters.Add(OP);

                    DataTable Country_table = new DataTable();
                    da.Fill(Country_table);

                    Dictionary<int, string> Temp_CountryDictionary = new Dictionary<int, string>();
                    
                    foreach(DataRow row in Country_table.Rows)
                    {
                        Temp_CountryDictionary.Add(Int32.Parse(row["Country_id"].ToString()), row["Country_Name"].ToString());
                    }
                    return Temp_CountryDictionary;
                }
            }
        }
        /// <summary>
        /// Searches in the CountriesDictionary a value and returns its key
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int GetCountryID(string x)
        {
            foreach (KeyValuePair<int, string> v in CountriesDictionary)
            {
                if (v.Value == x)
                    return v.Key;
            }
            return 0;
        }
    }
}
