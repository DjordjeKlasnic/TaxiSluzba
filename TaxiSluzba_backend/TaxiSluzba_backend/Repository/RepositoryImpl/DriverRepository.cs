using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class DriverRepository
    {
        public List<Driver> ReadDrivers()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivers.txt");
            List<Driver> drivers = new List<Driver>();
            foreach (string line in lines)
            {
                string[] userString = line.Split('|');
                List<Driving> drivingsList = new List<Driving>();
                Gender gender = (Gender)Enum.Parse(typeof(Gender), userString[5]);
                UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), userString[9]);
                Location location = new Location();
                Car car = new Car();
                foreach (string driving in userString[10].Split(';'))
                {

                }
                Driver driver = new Driver(Int32.Parse(userString[0]), userString[1], userString[2], userString[3], userString[4],
                    gender, userString[6], userString[7], userString[8], userRole, drivingsList,location,car);
                drivers.Add(driver);
            }
            return drivers;
        }
    }
}