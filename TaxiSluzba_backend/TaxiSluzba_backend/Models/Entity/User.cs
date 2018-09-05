using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiSluzba_backend.Models.Entity;

namespace TaxiSluzba_backend.Models
{
    public class User
    {
        private int iD;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private Gender gender;
        private string jmbg;
        private string phoneNumber;
        private string email;
        private UserRole role;
        private List<int> drivings;
        

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Jmbg { get { return jmbg; } set { jmbg = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public UserRole Role { get { return role; } set { role = value; } }
        public List<int> Drivings { get { return drivings; } set { drivings = value; } }
        public int ID { get { return iD; } set { iD = value; } }
        public Gender Gender { get { return gender; } set { gender = value; } }

        public User()
        {
        }

        public User(int iD, string username, string password, string firstName, string lastName, Gender gender, string jmbg, string phoneNumber, string email, UserRole role, List<int> drivings)
        {
            this.iD = iD;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Gender = gender;
            this.jmbg = jmbg;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.role = role;
            this.drivings = drivings;
        }
    }
}