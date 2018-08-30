using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models
{
    public class Car
    {
        private int id;
        private Driver driver;
        private int year;
        private string regNumber;
        private string taxiCarNumber;
        private Vehicle vehicle;

        public int Id { get => id; set => id = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public int Year { get => year; set => year = value; }
        public string RegNumber { get => regNumber; set => regNumber = value; }
        public string TaxiCarNumber { get => taxiCarNumber; set => taxiCarNumber = value; }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }

        public Car(int id, Driver driver, int year, string regNumber, string taxiCarNumber, Vehicle vehicle)
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