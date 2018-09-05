using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiSluzba_backend.Models;
using TaxiSluzba_backend.Repository.RepositoryImpl;

namespace TaxiSluzba_backend.Controllers
{
    public class LocationsController : ApiController
    {
        public LocationRepository rep = new LocationRepository();

        public IHttpActionResult Get()
        {
            List<Location> locations = rep.ReadLocations();
            if (locations == null)
            {
                return NotFound();
            }
            return Ok(locations);
        }

        public IHttpActionResult Get(int id)
        {
            List<Location> locations = rep.ReadLocations();
            if (locations != null)
            {
                foreach (Location location in locations)
                {
                    if (location.Id == id)
                        return Ok(location);
                }
            }
            return NotFound();
        }
    }
}
