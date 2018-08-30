using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class LocationRepository
    {
        public List<Location> ReadLocations()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Locations.txt");
            List<Location> locations = new List<Location>();
            foreach (string line in lines)
            {
                string[] userString = line.Split('|');
                Address address = new Address();
                Location location = new Location(Int32.Parse(userString[0]), address, Int32.Parse(userString[2]), Int32.Parse(userString[3]));
                locations.Add(location);
            }
            return locations;
        }
    }
}