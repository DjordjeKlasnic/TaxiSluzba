using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Repository.RepositoryImpl;

namespace TaxiSluzba_backend.Controllers
{
    public class DriversController : ApiController
    {
        public DriverRepository rep = new DriverRepository();

        public  IHttpActionResult Get()
        {
            List<Driver> drivers = rep.ReadDrivers();
            if (drivers == null)
            {
                return NotFound();
            }
            return Ok(drivers);
        }

        public IHttpActionResult Get(int id)
        {
            List<Driver> drivers = rep.ReadDrivers();
            if (drivers != null)
            {
                foreach (Driver driver in drivers)
                {
                    if (driver.ID == id)
                        return Ok(driver);
                }
            }
            return NotFound();
        }

        [ResponseType(typeof(Driver))]
        public IHttpActionResult Post(Driver driver)
        {
            bool write = rep.WriteDriver(driver);
            if (write == false)
                return Conflict();
            return Ok(driver);
        }

        public IHttpActionResult Put(Driver driver)
        {
            Driver d = rep.EditDriver(driver);
            if (d == null)
                return Conflict();
            return Ok(d);
        }
    }
}
