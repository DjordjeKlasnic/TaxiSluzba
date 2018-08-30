using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class CarRepository
    {
            public List<Car> ReadCars()
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Cars.txt");
                List<Car> cars = new List<Car>();
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                Driver driver = new Driver();
                Vehicle vehicle = new Vehicle();
                Car car = new Car(Int32.Parse(userString[0]), driver, Int32.Parse(userString[2]), userString[3], userString[4], vehicle);
                    cars.Add(car);
                }
                return cars;
            }
        }
}