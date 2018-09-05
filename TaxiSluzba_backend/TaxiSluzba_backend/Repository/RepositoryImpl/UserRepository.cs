using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;
using TaxiSluzba_backend.Repository.RepositoryInterface;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class UserRepository:IUserRepository
    {
        DrivingRepository drivingRepository = new DrivingRepository();
        public List<User> ReadUsers()
        {
            if (System.IO.File.Exists(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt");
                List<User> users = new List<User>();
                foreach (string line in lines)
                {
                    string[] userString = line.Split('|');
                    if (userString.Count() < 10 || userString.Count() > 11)
                        return null;
                    List<int> drivingsList = new List<int>();
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), userString[5]);
                    UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), userString[9]);
                    if (userString[10] != "")
                    {
                        string[] driving = userString[10].Split(';');
                        {
                            foreach (string s in driving)
                            {
                                drivingsList.Add(Int32.Parse(s));
                            }
                        }
                    }
                    User user = new User(Int32.Parse(userString[0]), userString[1], userString[2], userString[3], userString[4],
                        gender, userString[6], userString[7], userString[8], userRole, drivingsList);
                    users.Add(user);
                }
                return users;
            }
            return null;
        }




        public User WriteUser(User user)
        {
            List<User> users = ReadUsers();
            if (users != null)
            {
                foreach (User u in users)
                {
                    if (u.Username == user.Username)
                    {
                        return null;
                    }
                }
                user.ID = users.Count + 1;
                if(user.FirstName=="" || user.Password=="" || user.LastName=="" || user.Jmbg.Length!=13 || 
                    user.PhoneNumber.Length!=10 || user.Email == "")
                {
                    return null;
                }
                string userString = "";
                userString = userString + user.ID + '|' + user.Username + "|" + user.Password + "|" + user.FirstName + "|"
                    + user.LastName + "|" + user.Gender + "|" + user.Jmbg + "|" + user.PhoneNumber +
                    "|" + user.Email + "|" + user.Role + "|";

                using (StreamWriter w = File.AppendText(@"C: \Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt"))
                {
                    w.WriteLine(userString);
                }

                return user;
            }
            return null;
        }




        public User EditUser(User user)
        {
            if (user.FirstName != "" || user.Password != "" || user.LastName != "" || user.Jmbg.Length == 13 ||
                    user.PhoneNumber.Length == 10 || user.Email != "")
            {
                List<User> users = ReadUsers();
                User newUser = new User();
                if (users != null)
                {
                    foreach (User u in users)
                    {
                        if (u.Username == user.Username)
                        {
                            newUser = u;
                        }
                    }
                    users.Remove(newUser);

                    users.Add(user);
                    using (StreamWriter w = new StreamWriter(@"C: \Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt"))
                    {
                        foreach(User u in users)
                        {
                            string userString = "";
                            userString = userString + u.ID + '|' + u.Username + "|" + u.Password + "|" + u.FirstName + "|"
                                + u.LastName + "|" + u.Gender + "|" + u.Jmbg + "|" + u.PhoneNumber +
                                "|" + u.Email + "|" + u.Role + "|";
                            bool b = false;
                            if(u.Drivings.Count!=0)
                                foreach(int d in u.Drivings)
                                {
                                    if (b == true)
                                        userString = userString + ";";
                                    userString = userString + d;
                                    b = true;
                                }
                            w.WriteLine(userString);
                        }
                    }

                    return user;
                }
            }
            return null;
        }
    }
}