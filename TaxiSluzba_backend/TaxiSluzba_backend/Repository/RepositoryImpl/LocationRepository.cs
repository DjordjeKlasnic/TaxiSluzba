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
            AddressRepository addressRepository = new AddressRepository();
            if (System.IO.File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Locations.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Locations.txt");
                List<Location> locations = new List<Location>();
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                    if (userString.Count() != 4 )
                        return null;
                    Address address = new Address();
                    foreach (Address a in addressRepository.ReadAddresses())
                    {
                        if (a.ID == Int32.Parse(userString[1]))
                        {
                            address = a;
                            break;
                        }
                    }
                    Location location = new Location(Int32.Parse(userString[0]), address, Int32.Parse(userString[2]), Int32.Parse(userString[3]));
                    locations.Add(location);
                }
                return locations;
            }
            return null;
        }
    }
}