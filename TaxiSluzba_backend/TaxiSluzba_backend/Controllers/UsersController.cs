using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Repository.RepositoryImpl;
using TaxiSluzba_backend.Repository.RepositoryInterface;

namespace TaxiSluzba_backend.Controllers
{
    public class UsersController : ApiController
    {
        public UserRepository rep = new UserRepository();

        public List<User> Get()
        {
            return rep.ReadUsers();
        }

        // GET api/values/5
        public User Get(int id)
        {
            User user = new User();
            user.FirstName = "Ime";
            user.LastName = "Prezime";
            user.Password = "sifra";
            user.Username = "username";
            return user;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
