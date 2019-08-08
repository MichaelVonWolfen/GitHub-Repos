using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    class Log
    {
        /// <summary>
        /// Ads to the LogMessages file the message parsed as parameter
        /// </summary>
        /// <param name="message"></param>
        public static void LogMessage(OracleException exception)
        {
            string path = @"Logs.txt";
            if (File.Exists(path))
            {
                using (var logFile = new StreamWriter(path, true))
                {
                    var macAddr =
                        (
                            from nic in NetworkInterface.GetAllNetworkInterfaces()
                            where nic.OperationalStatus == OperationalStatus.Up
                            select nic.GetPhysicalAddress().ToString()
                        ).FirstOrDefault();
                    logFile.WriteLine(DateTime.UtcNow.ToString() + "\t\t" + macAddr + "\t\t" + exception.Message +
                                        "\t\t" + exception.StackTrace + "\t\t" + exception.Errors);
                }
            }
            else
            {
                using (var logFile = new StreamWriter(path, true))
                {
                    logFile.WriteLine("Date Time:\t\t\tMac Adress:\t\t\tError Message:\t\t\tStack:\t\t\tError: \n\n");
                }
                    LogMessage(exception); 
            }
        }
    }
}
