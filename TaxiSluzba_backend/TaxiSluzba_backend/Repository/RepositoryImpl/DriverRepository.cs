using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class DriverRepository
    {
        public List<Driver> ReadDrivers()
        {
            LocationRepository locationRepository = new LocationRepository();
            CarRepository carRepository = new CarRepository();
            DrivingRepository drivingRepository = new DrivingRepository();
            if (System.IO.File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivers.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivers.txt");
                List<Driver> drivers = new List<Driver>();
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                    if (userString.Count() < 12 || userString.Count() > 13)
                        return null;

                    List<int> drivingsList = new List<int>();
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), userString[5]);
                    UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), userString[9]);
                    Location location = new Location();
                    List<Location> listLocations = locationRepository.ReadLocations();
                    if (listLocations != null)
                    {
                        foreach (Location l in listLocations)
                        {
                            if (l.Id == Int32.Parse(userString[11]))
                            {
                                location = l;
                                break;
                            }
                        }
                    }
                    Car car = new Car();
                    List<Car> listCars = carRepository.ReadCars();
                    if (listCars != null)
                    {
                        foreach (Car c in listCars)
                        {
                            if (c.Id == Int32.Parse(userString[11]))
                            {
                                car = c;
                                break;
                            }
                        }
                    }
                    if (userString[12] != "")
                    {
                        string[] driving = userString[12].Split(';');
                        {
                            foreach (string s in driving)
                            {
                                drivingsList.Add(Int32.Parse(s));
                            }
                        }
                    }
                    Driver driver = new Driver(Int32.Parse(userString[0]), userString[1], userString[2], userString[3], userString[4],
                        gender, userString[6], userString[7], userString[8], userRole, location, car, drivingsList);
                    drivers.Add(driver);
                }
                return drivers;
            }
            return null;
        }



        public bool WriteDriver(Driver driver)
        {
            List<Driver> drivers = ReadDrivers();
            if (drivers != null)
            {
                foreach (Driver d in drivers)
                {
                    if (d.Username == driver.Username)
                    {
                        return false;
                    }
                }
                driver.ID = drivers.Count + 1;
                if (driver.FirstName == "" || driver.Password == "" || driver.LastName == "" || driver.Jmbg.Length != 13 ||
                    driver.PhoneNumber.Length != 10 || driver.Email == "")
                {
                    return false;
                }
                string userString = "";
                userString = userString + driver.ID + '|' + driver.Username + "|" + driver.Password + "|" + driver.FirstName + "|"
                    + driver.LastName + "|" + driver.Gender + "|" + driver.Jmbg + "|" + driver.PhoneNumber +
                    "|" + driver.Email + "|" + driver.Role + "|"+ driver.Location + "|"+driver.Car+"|";

                using (StreamWriter w = File.AppendText(@"C: \Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt"))
                {
                    w.WriteLine(userString);
                }

                return true;
            }
            return false;
        }


        public Driver EditDriver(Driver driver)
        {
            if (driver.FirstName != "" && driver.Password != "" && driver.LastName != "" && driver.Jmbg.Length == 13 &&
                    driver.PhoneNumber.Length == 10 && driver.Email != "")
            {
                List<Driver> drivers = ReadDrivers();
                Driver newUser = new Driver();
                if (drivers != null)
                {
                    foreach (Driver d in drivers)
                    {
                        if (d.Username == driver.Username)
                        {
                            newUser = d;
                        }
                    }
                    drivers.Remove(newUser);

                    drivers.Add(driver);
                    using (StreamWriter w = new StreamWriter(@"C: \Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivers.txt"))
                    {
                        foreach (Driver u in drivers)
                        {
                            string userString = "";
                            userString = userString + u.ID + '|' + u.Username + "|" + u.Password + "|" + u.FirstName + "|"
                                + u.LastName + "|" + u.Gender + "|" + u.Jmbg + "|" + u.PhoneNumber +
                                "|" + u.Email + "|" + u.Role + "|" + u.Location.Id + "|" + u.Car.Id + "|" ;

                            bool b = false;
                            if (u.Drivings.Count != 0)
                                foreach (int d in u.Drivings)
                                {
                                    if (b == true)
                                        userString = userString + ";";
                                    userString = userString + d;
                                    b = true;
                                }
                            w.WriteLine(userString);
                        }
                    }

                    return driver;
                }
            }
            return null;
        }
    }
}