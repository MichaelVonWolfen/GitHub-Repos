using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.Entities
{
    class Rent_Rooms
    {
        public int Rent_RoomsID { get; }
        public DateTime START_DATE { get; }
        public DateTime END_DATE { get; }
        public int ROOM_ID { get; }
        public string ReservationID { get; }
        public Rent_Rooms(int Rent_RoomsID,DateTime START_DATE, DateTime END_DATE, int ROOM_ID, string ReservationID)
        {
            this.END_DATE = END_DATE;
            this.Rent_RoomsID = Rent_RoomsID;
            this.START_DATE = START_DATE;
            this.ROOM_ID = ROOM_ID;
            this.ReservationID = ReservationID;
        }
        public Rent_Rooms(DateTime START_DATE, DateTime END_DATE, int ROOM_ID,string ReservationID)
        {
            this.END_DATE = END_DATE;
            this.START_DATE = START_DATE;
            this.ROOM_ID = ROOM_ID;
            this.ReservationID = ReservationID;
        }
    }
}
