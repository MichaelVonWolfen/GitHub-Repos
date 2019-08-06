using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.DAL
{
    static class GlobalDictionary
    {
        public static Dictionary<int, string> LocationDictionary
        {
            get; set;
        }
        public static Dictionary<int, string> HotelsDictionary { get; set; }
        
    }
}
