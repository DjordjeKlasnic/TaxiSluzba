using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class CommentRepository
    {
        public List<Comment> ReadComments()
        {
            UserRepository userRepository = new UserRepository();
            DrivingRepository drivingRepository = new DrivingRepository();
            if (System.IO.File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Comments.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Comments.txt");
                List<Comment> comments = new List<Comment>();

                foreach (string line in lines)
                {
                    int exists = 0;
                    string[] userString = line.Split('|');
                    if (userString.Count() != 6)
                        return null;
                    User customer = new User();
                    List<User> users = userRepository.ReadUsers();
                    if (users != null)
                    {
                        foreach (User u in users)
                        {
                            if (u.ID == Int32.Parse(userString[3]))
                            {
                                customer = u;
                                break;
                            }
                        }
                    }
                    Driving driving = new Driving();
                    List<Driving> listDrivings = drivingRepository.ReadDrivings();
                    if (listDrivings != null)
                    {
                        foreach (Driving d in drivingRepository.ReadDrivings())
                        {
                            if (d.Id == Int32.Parse(userString[4]))
                            {
                                driving = d;
                                break;
                            }
                        }
                    }

                    string[] dateSplit = line.Split(';');
                    DateTime Date = new DateTime(Int32.Parse(dateSplit[0]), Int32.Parse(dateSplit[1]), Int32.Parse(dateSplit[2]));
                    Comment comment = new Comment(Int32.Parse(userString[0]), userString[1], Date, customer, driving, Int32.Parse(userString[5]));
                    comments.Add(comment);
                }
                return comments;
            }
            return null;
        }
    }
}