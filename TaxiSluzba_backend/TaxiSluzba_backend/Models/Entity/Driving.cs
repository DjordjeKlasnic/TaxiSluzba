using System;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Models.Entity
{
    public class Driving
    {
        private int id;
        private DateTime date;
        private Location startLocation;

        [System.ComponentModel.DefaultValue(Vehicle.Car)]
        private Vehicle vehicle;

        private User dispatcher;
        private Location destinationLocation;
        private User customer;
        private Driver driver;
        private double price;
        private Comment comment;
        private DrivingStatus drivingStatus;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public Location StartLocation { get => startLocation; set => startLocation = value; }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public User Dispatcher { get => dispatcher; set => dispatcher = value; }
        public Location DestinationLocation { get => destinationLocation; set => destinationLocation = value; }
        public User Customer { get => customer; set => customer = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public double Price { get => price; set => price = value; }
        public Comment Comment { get => comment; set => comment = value; }
        public DrivingStatus DrivingStatus { get => drivingStatus; set => drivingStatus = value; }

        public Driving(int id, DateTime date, Location startLocation, Vehicle vehicle, User dispatcher, Location destinationLocation, User customer, Driver driver, double price, Comment comment, DrivingStatus drivingStatus)
        {
            this.Id = id;
            Date = date;
            StartLocation = startLocation;
            Vehicle = vehicle;
            Dispatcher = dispatcher;
            DestinationLocation = destinationLocation;
            Customer = customer;
            Driver = driver;
            Price = price;
            Comment = comment;
            DrivingStatus = drivingStatus;
        }

        public Driving()
        {
        }
    }
}