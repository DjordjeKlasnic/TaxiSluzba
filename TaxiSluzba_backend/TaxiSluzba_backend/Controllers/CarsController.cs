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

    public class CarsController : ApiController
    {
        public CarRepository rep = new CarRepository();

        public IHttpActionResult Get()
        {
            List<Car> cars = rep.ReadCars();
            if (cars == null)
            {
                return NotFound();
            }
            return Ok(cars);
        }

        public IHttpActionResult Get(int id)
        {
            List<Car> cars = rep.ReadCars();
            if (cars != null)
            {
                foreach (Car car in cars)
                {
                    if (car.Id == id)
                        return Ok(car);
                }
            }
            return NotFound();
        }
    }
}
