using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models.Entity
{
    public class Comment
    {
        private int id;
        private string description;
        private DateTime date;
        private User user;
        private Driving driving;
        private int evaluation;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public User User { get => user; set => user = value; }
        public Driving Driving { get => driving; set => driving = value; }
        public int Evaluation { get => evaluation; set => evaluation = value; }

        public Comment(int id, string description, DateTime date, User user, Driving driving, int evaluation)
        {
            this.Id = id;
            Description = description;
            Date = date;
            User = user;
            Driving = driving;
            Evaluation = evaluation;
        }
    }
}