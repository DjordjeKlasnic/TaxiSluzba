using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Models.DTO;
using TaxiSluzba_backend.Repository.RepositoryImpl;
using TaxiSluzba_backend.Repository.RepositoryInterface;

namespace TaxiSluzba_backend.Controllers
{
    public class UsersController : ApiController
    {
        public UserRepository rep = new UserRepository();

        public IHttpActionResult Get()
        {
            List<User> lista = rep.ReadUsers();
            if (lista == null)
            {
                return NotFound();
            }
            return Ok(lista);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            List<User> users = rep.ReadUsers();
            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user.ID == id)
                        return Ok(user);
                }
            }
            return NotFound();
        }

        // POST api/values

        [ResponseType(typeof(User))]
        public IHttpActionResult Post(User user)
        {
            User u=rep.WriteUser(user);
            if (u == null)
                return Conflict();
            return Ok(u);
        }

        // PUT api/values/5
        public IHttpActionResult Put(User user)
        {
            User u = rep.EditUser(user);
            if (u == null)
                return Conflict();
            return Ok(u);
        }

        [HttpPost]
        [Route("api/login")]
        [ResponseType(typeof(User))]
        public IHttpActionResult Login(LoginDTO loginUser)
        {
            DriverRepository dr = new DriverRepository();
            List<User> users = rep.ReadUsers();
            List<Driver> drivers = dr.ReadDrivers();
            User logUser=null;
            if (users != null && drivers != null)
            {
                foreach (User user in users)
                {
                    if (user.Username == loginUser.Username && user.Password == loginUser.Password)
                    {
                        logUser = user;
                    }
                }
                foreach (User user in drivers)
                {
                    if (user.Username == loginUser.Username && user.Password == loginUser.Password)
                    {
                        logUser = user;
                    }
                }
                if (logUser != null)
                    return Ok(logUser);
            }
            
            return NotFound();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
