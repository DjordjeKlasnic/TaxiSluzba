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

    public class AdressesController : ApiController
    {
        public AddressRepository rep = new AddressRepository();

        public IHttpActionResult Get()
        {
            List<Address> addresses = rep.ReadAddresses();
            if (addresses == null)
            {
                return NotFound();
            }
            return Ok(addresses);
        }


        public IHttpActionResult Get(int id)
        {
            List<Address> addresses = rep.ReadAddresses();
            foreach (Address address in addresses)
            {
                if (address.ID == id)
                    return Ok(address);
            }
            return NotFound();
        }
    }
}
