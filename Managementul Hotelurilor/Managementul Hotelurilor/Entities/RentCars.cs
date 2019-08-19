using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.Entities
{
    class RentCars
    {
        public int RENT_CARS_TYPE_ID { get; set; }
        public string CAR_NAME_TYPE { get; set; }
        public float RENT_PRICE { get; set; }
        public int HOTEL_ID { get; set; }

        public RentCars(int RENT_CARS_TYPE_ID, string CAR_NAME_TYPE, float RENT_PRICE, int HOTEL_ID)
        {
            this.CAR_NAME_TYPE = CAR_NAME_TYPE;
            this.HOTEL_ID = HOTEL_ID;
            this.RENT_CARS_TYPE_ID = RENT_CARS_TYPE_ID;
            this.RENT_PRICE = RENT_PRICE;
        }
        public RentCars()
        {

        }
        

    }
}
