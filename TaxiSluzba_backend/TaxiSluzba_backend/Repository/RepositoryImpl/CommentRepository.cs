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
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Djole\Documents\Visual Studio 2017\Projects\TaxiSluzba_backend\TaxiSluzba_backend\Files\Comments.txt");
            List<Comment> comments = new List<Comment>();
            foreach (string line in lines)
            {
                string[] userString = line.Split('|');
                User user = new User();
                Driving driving = new Driving();
                string[] dateSplit = line.Split(';');
                DateTime Date = new DateTime(Int32.Parse(dateSplit[0]), Int32.Parse(dateSplit[1]), Int32.Parse(dateSplit[2]));
                Comment comment = new Comment(Int32.Parse(userString[0]), userString[1], Date, user, driving,Int32.Parse(userString[5]));
                comments.Add(comment);
            }
            return comments;
        }
    }
}