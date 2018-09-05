using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiSluzba_backend.Models.Entity;
using TaxiSluzba_backend.Repository.RepositoryImpl;

namespace TaxiSluzba_backend.Controllers
{
    public class DrivingsController : ApiController
    {
        public DrivingRepository rep = new DrivingRepository();

        public IHttpActionResult Get()
        {
            List<Driving> drivings = rep.ReadDrivings();
            if (drivings == null)
            {
                return NotFound();
            }
            return Ok(drivings);
        }

        public IHttpActionResult Get(int id)
        {
            List<Driving> drivings = rep.ReadDrivings();
            if (drivings != null)
            {
                foreach (Driving driving in drivings)
                {
                    if (driving.Id == id)
                        return Ok(driving);
                }
            }
            return NotFound();
        }
    }
}
