using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Models
{
    public class Driver:User
    {
        private Location location;
        private Car car;

        public Driver()
        {
        }

        public Driver(int iD, string username, string password, string firstName, string lastName, Gender gender, string jmbg, string phoneNumber, string email, UserRole role, Location l, Car c,List<int> drivings)
        {
            ID = iD;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Jmbg = jmbg;
            PhoneNumber = phoneNumber;
            Email = email;
            Role = role;
            location = l;
            car = c;
            Drivings = drivings;
        }


        public Location Location { get { return location; } set { location = value; } }
        public Car Car { get { return car; } set { car = value; } }
    }
}