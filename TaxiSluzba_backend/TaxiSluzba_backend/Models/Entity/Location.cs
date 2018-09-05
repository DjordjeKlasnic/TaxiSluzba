using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models
{
    public class Location
    {
        private int id;
        private Address address;
        private int xCoordinate;
        private int yCoordinate;

        public Address Address {
            get { return address; }
            set { address = value; }
        }
        public int XCoordinate { get { return xCoordinate; } set { xCoordinate = value; } }
        public int YCoordinate { get {return  yCoordinate; } set { yCoordinate = value; } }
        public int Id { get { return id; } set { id = value; } }

        public Location(int id, Address address, int xCoordinate, int yCoordinate)
        {
            Id = id;
            Address = address;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public Location()
        {
        }
    }
}