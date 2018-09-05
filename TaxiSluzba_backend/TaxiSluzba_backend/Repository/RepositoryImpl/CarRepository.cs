using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class CarRepository
    {
            public List<Car> ReadCars()
            {
            List<Car> cars = new List<Car>();
            if (File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Cars.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Cars.txt");
                
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                    if (userString.Count() != 6)
                        return null;
                    Vehicle vehicle = (Vehicle)Enum.Parse(typeof(Vehicle), userString[5]);
                    Car car = new Car(Int32.Parse(userString[0]), Int32.Parse(userString[1]), Int32.Parse(userString[2]), userString[3], userString[4], vehicle);
                    cars.Add(car);
                }
                return cars;
            }
            return null;
        }
        }
}