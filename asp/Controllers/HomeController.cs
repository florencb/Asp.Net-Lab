﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        //public IActionResult Index()
        //{
        //    Trips db = new Trips();
        //    ViewBag.Trip = new Trip()
        //    {
        //        name = "sample trip",
        //        DateCreated = DateTime.Now
        //    };
        //    var trips = db.GetAllTrips();

        //    return View(); //pass trips to the view
        //}
    }
}
