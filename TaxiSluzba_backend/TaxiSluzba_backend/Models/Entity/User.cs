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
        private List<Driving> drivings;
        

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public UserRole Role { get => role; set => role = value; }
        public List<Driving> Drivings { get => drivings; set => drivings = value; }
        public int ID { get => iD; set => iD = value; }

        public User()
        {
        }

        public User(int iD, string username, string password, string firstName, string lastName, Gender gender, string jmbg, string phoneNumber, string email, UserRole role, List<Driving> drivings)
        {
            this.iD = iD;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.jmbg = jmbg;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.role = role;
            this.drivings = drivings;
        }
    }
}