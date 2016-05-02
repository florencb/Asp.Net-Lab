using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using asp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.Controllers.TripsController
{

    //private DatabaseContext db = new Data();
    public class TripsController : Controller
    {
        // GET: api/values
        [HttpGet]
 

     
        //public JsonResult Get()
        //{
        //    var trips = db.Trips;
        //    var results = Mapper.Map<IEnumerable<TripViewModel>>(trips);
        //    return Json(trips);
        //}
        //// GET api/values/5
        //[HttpGet("{id}")]

        //public Trip Get(int id)
        //    var trip = db.Trips.Where(a => a.ID == id).Single();
        //    var results = Mapper.Map<Trip>(trip)
        //    return Trip;

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
      
    }
}
