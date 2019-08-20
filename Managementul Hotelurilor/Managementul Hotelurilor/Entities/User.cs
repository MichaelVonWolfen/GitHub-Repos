using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managementul_Hotelurilor.Entities
{
    class User
    {
        public string Username { get; }
        public string Password { get; }
        public string Email { get; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

            Email = DAL.DalUsers.GetEmail(Username, Password);
            //Make method to check if the user exists 
            //if exists then log in and get mail
            //else throw error
        }
        public User(string Username,string Password,string Email)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;

            //Add to database all values.
        }
    }
}
