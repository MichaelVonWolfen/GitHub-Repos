using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.Entities
{
    class User
    {
        private string Username;
        private string Password;
        private string Email;
        private string CardNumber;
        private string CVV;
        private DateTime ExpirationDate;

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

            //Make method to check if the user exists 
            //if exists then log in
            //else throw error
        }
        public User(string Username,string Password,string Email,string CardNumber, string CVV, string month, string year)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.CardNumber = CardNumber;
            this.CVV = CVV;
            ExpirationDate = DateTime.Parse(month + "." + year);
        }
    }
}
