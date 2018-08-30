using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.Entity;
using TaxiSluzba_backend.Repository.RepositoryInterface;

namespace TaxiSluzba_backend.Repository.RepositoryImpl
{
    public class UserRepository:IUserRepository
    {
        public List<User> ReadUsers()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Users.txt");
            List<User> users = new List<User>();
            foreach (string line in lines)
            {
                string[] userString = line.Split('|');
                List<Driving> drivingsList = new List<Driving>();
                Gender gender = (Gender)Enum.Parse(typeof(Gender), userString[5]);
                UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), userString[9]);

                foreach (string driving in userString[10].Split(';'))
                {

                }
                User user = new User(Int32.Parse(userString[0]), userString[1], userString[2], userString[3], userString[4],
                    gender, userString[6], userString[7], userString[8], userRole,  drivingsList);
                users.Add(user);
            }
            return users;
        }
    }
}