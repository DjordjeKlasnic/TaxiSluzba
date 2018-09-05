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

        public int Id { get { return id; } set { id = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public Location StartLocation { get { return startLocation; } set { startLocation = value; } }
        public Vehicle Vehicle { get { return vehicle; } set { vehicle = value; } }
        public User Dispatcher { get { return dispatcher; } set { dispatcher = value; } }
        public Location DestinationLocation { get { return destinationLocation; } set { destinationLocation = value; } }
        public User Customer { get { return customer; } set { customer = value; } }
        public Driver Driver { get { return driver; } set { driver = value; } }
        public double Price { get { return price; } set { price = value; } }
        public Comment Comment { get { return comment; } set { comment = value; } }
        public DrivingStatus DrivingStatus { get { return drivingStatus; } set { drivingStatus = value; } }

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