using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using asp.Models;
using asp.ViewModels;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.Controllers.TripsController
{
    //private DatabaseContext db = new Data();
    public class TripsController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: api/values
        [HttpGet]
   
        public JsonResult Get()
        {
            var trips = db.Trip;
            var results = Mapper.Map<IEnumerable<TripViewModel>>(trips);
            return Json(trips);
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var trip = db.Trip.Where(a => a.ID == id).Single();
            var results = Mapper.Map<Trip>(trip);
            return Json(results);
        }


           // POST api/values
        [HttpPost]
        public JsonResult Post(TripViewModel trip)
        {
            var newTrip = Mapper.Map<Trip>(trip);
            newTrip.UserName = "user1";
            if (ModelState.IsValid)
            {
                db.Trip.Add(newTrip);
                db.SaveChanges();
            }
            var result = Mapper.Map<TripViewModel>(newTrip);
            return Json(result);
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
