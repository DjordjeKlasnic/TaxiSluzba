using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models
{
    public class Car
    {
        private int id;
        private int driver;
        private int year;
        private string regNumber;
        private string taxiCarNumber;
        private Vehicle vehicle;

        public int Id { get { return id; } set { id = value; } }
        public int Driver { get { return driver; } set { driver = value; } }
        public int Year { get { return year; } set { year = value; } }
        public string RegNumber { get { return regNumber; } set { regNumber = value; } }
        public string TaxiCarNumber { get { return taxiCarNumber; } set { taxiCarNumber = value; } }
        public Vehicle Vehicle { get { return vehicle; } set { vehicle = value; } }

        public Car(int id, int driver, int year, string regNumber, string taxiCarNumber, Vehicle vehicle)
        {
            this.Id = id;
            Driver = driver;
            Year = year;
            RegNumber = regNumber;
            TaxiCarNumber = taxiCarNumber;
            Vehicle = vehicle;
        }

        public Car()
        {
        }
    }
}