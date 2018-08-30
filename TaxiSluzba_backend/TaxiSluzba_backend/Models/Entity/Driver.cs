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

        public Driver(int iD, string username, string password, string firstName, string lastName, Gender gender, string jmbg, string phoneNumber, string email, UserRole role, List<Driving> drivings,Location l,Car c) : base(iD, username, password, firstName, lastName, gender, jmbg, phoneNumber, email, role, drivings)
        {
            location = l;
            car = c;
        }


        public Location Location { get => location; set => location = value; }
        public Car Car { get => car; set => car = value; }
    }
}