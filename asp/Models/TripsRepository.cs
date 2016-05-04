using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.Models
{
    public class TripsRepository
    {
        private DatabaseContext db;

        public TripsRepository(DatabaseContext context)
        {
            db = context;
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            var trips = db.Trip.Include(a => a.Stops);
            return trips;
        }

        public Trip GetTrip(int id)
        {
            var trip = db.Trip.Include(a => a.Stops).Where(a => a.ID == id).Single();
            return trip;
        }

        public Trip Post(Trip trip)
        {
            db.Trip.Add(trip);
            db.SaveChanges();
            return trip;
        }
    }
}
