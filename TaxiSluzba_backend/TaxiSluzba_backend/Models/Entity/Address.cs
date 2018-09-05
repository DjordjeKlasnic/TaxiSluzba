using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models
{
    public class Address
    {

        private int iD;
        private string street;
        private string city;
        private int zipCode;

        public int ID { get { return iD; } set { iD = value; }}
        public string Street { get { return street; } set { street = value; }}
        public string City { get { return city; } set { city = value; }}
        public int ZipCode { get { return zipCode; } set { zipCode = value; }}

        public Address(int iD, string street, string city, int zipCode)
        {
            ID = iD;
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        public Address()
        {
        }
    }
}