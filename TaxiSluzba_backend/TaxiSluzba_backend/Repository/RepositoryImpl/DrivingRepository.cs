using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class DrivingRepository
    {
        public List<Driving> ReadDrivings()
        {
            LocationRepository locationRepository = new LocationRepository();
            UserRepository userRepository = new UserRepository();
            DriverRepository driverRepository = new DriverRepository();
            CommentRepository commentRepository = new CommentRepository();
            if (System.IO.File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivings.txt"))
                {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Drivings.txt");
                List<Driving> drivings = new List<Driving>();
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                    if (userString.Count() != 11)
                        return null;
                    string[] dateSplit = userString[1].Split(';');
                    Location location = null;
                    Location destination = null;
                    foreach (Location l in locationRepository.ReadLocations())
                    {
                        if (userString[2] != "")
                        {
                            if (l.Id == Int32.Parse(userString[2]))
                            {
                                location = l;
                                continue;
                            }
                        }
                        if (userString[5] != "")
                        {
                            if (l.Id == Int32.Parse(userString[5]))
                            {
                                destination = l;
                            }
                        }
                    }
                    
                    Vehicle vehicle = new Vehicle();

                    User dispatcher = new User();
                    User customer = new User();
                    List<User> listUsers = userRepository.ReadUsers();
                    if (listUsers != null)
                    {

                        foreach (User u in listUsers)
                        {
                            if (userString[4] != "")
                            {
                                if (u.ID == Int32.Parse(userString[4]))
                                {
                                    dispatcher = u;
                                    continue;
                                }
                            }
                            if (userString[6] != "")
                            {
                                if (u.ID == Int32.Parse(userString[6]))
                                {
                                    customer = u;
                                }
                            }
                        }
                    }

                    Driver driver = new Driver();
                    List<Driver> listDrivers = driverRepository.ReadDrivers();
                    if (listDrivers != null && userString[7]!="")
                    {
                        foreach (Driver d in listDrivers)
                        {
                            if (d.ID == Int32.Parse(userString[7]))
                            {
                                driver = d;
                                break;
                            }
                        }
                    }

                    Comment comment = new Comment();
                    List<Comment> comments = commentRepository.ReadComments();
                    if (comments != null && userString[9]!="")
                    {
                        foreach (Comment c in comments)
                        {
                            if (c.Id == Int32.Parse(userString[9]))
                            {
                                comment = c;
                                break;
                            }
                        }
                    }
                    DrivingStatus drivingStatus = (DrivingStatus)Enum.Parse(typeof(DrivingStatus), userString[10]);
                    DateTime Date = new DateTime(Int32.Parse(dateSplit[0]), Int32.Parse(dateSplit[1]), Int32.Parse(dateSplit[2]));
                    Driving driving = new Driving(Int32.Parse(userString[0]), Date, location, vehicle,
                    dispatcher, destination, customer, driver, Double.Parse(userString[8]), comment, drivingStatus);
                    drivings.Add(driving);
                }
                return drivings;
            }
            return null;
        }

    }
}