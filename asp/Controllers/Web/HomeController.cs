using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using asp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/  
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        private DatabaseContext db = new DatabaseContext();
        // GET: /<controller>/

        public IActionResult Index()
            {
            var Trips = db.Trip.Include(a => a.Stops);
        //ViewBag.test = Trips;
        var repo = new TripsRepository(db);
            //ViewBag.test = repo;
            return View(repo.GetAllTrips());
        }
}
}
