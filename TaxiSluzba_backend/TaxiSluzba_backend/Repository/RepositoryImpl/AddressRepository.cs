using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class AddressRepository
    {
        public List<Address> ReadAddress()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Addresses.txt");
            List<Address> addresses = new List<Address>();
            foreach (string line in lines)
            {
                string[] userString = line.Split('|');
                Address address = new Address(Int32.Parse(userString[0]), userString[1], userString[2], Int32.Parse(userString[3]));
                addresses.Add(address);
            }
            return addresses;
        }
    }
}