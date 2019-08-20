using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    class DalUsers
    {
        static public string GetEmail(string username, string password)
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleCommand OA = new OracleCommand("GETemail", conn))
                {
                    OA.CommandType = CommandType.StoredProcedure;
                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "usernameVar";
                    OP1.OracleDbType = OracleDbType.Varchar2;
                    OP1.Direction = ParameterDirection.Input;
                    OP1.Value = username;

                    OracleParameter OP2 = new OracleParameter();
                    OP2.ParameterName = "passwordVar";
                    OP2.OracleDbType = OracleDbType.Varchar2;
                    OP2.Direction = ParameterDirection.Input;
                    OP2.Value = password;


                    OracleParameter OP3 = new OracleParameter();
                    OP3.ParameterName = "e_mail";
                    OP3.OracleDbType = OracleDbType.Varchar2;
                    OP3.Direction = ParameterDirection.ReturnValue;



                    OA.Parameters.Add(OP1);
                    OA.Parameters.Add(OP2);
                    OA.Parameters.Add(OP3);

                    OA.ExecuteNonQuery();

                    return Convert.ToString(OA.Parameters["e_mail"].Value);
                }
            }
            
        }
        static public void AddNewUser(Entities.User user)
        {
            using (OracleConnection conn = DatabaseConection.GetOracleConnection())
            {
                using (OracleCommand OA = new OracleCommand("Insert_new_user", conn))
                {
                    OA.CommandType = CommandType.StoredProcedure;
                    OracleParameter OP1 = new OracleParameter();
                    OP1.ParameterName = "nm";
                    OP1.OracleDbType = OracleDbType.Varchar2;
                    OP1.Direction = ParameterDirection.Input;
                    OP1.Value = user.Username;

                    OracleParameter OP2 = new OracleParameter();
                    OP2.ParameterName = "pasword";
                    OP2.OracleDbType = OracleDbType.Varchar2;
                    OP2.Direction = ParameterDirection.Input;
                    OP2.Value = user.Password;

                    OracleParameter OP3 = new OracleParameter();
                    OP3.ParameterName = "mail";
                    OP3.OracleDbType = OracleDbType.Varchar2;
                    OP3.Direction = ParameterDirection.Input;
                    OP3.Value = user.Email;


                    OA.Parameters.Add(OP1);
                    OA.Parameters.Add(OP2);
                    OA.Parameters.Add(OP3);

                    OA.ExecuteNonQuery();

                }
            }
        }
    }
}
