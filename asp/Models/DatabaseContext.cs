﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace asp.Models
{
    public class DatabaseContext : IdentityDbContext<AppUser> 
    {
        //public System.Data.Entity.DbSet<asp.Models.Trip> Trip { get; set; }
        //public System.DataMisalignedException.Entity.DbSet<asp.Models.Stop> Stop { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DbSet<Stop> Stops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString =
               Startup.Configuration["Data:DefaultConnection:TripsConnectionString"];
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder); 
            
        }
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

    }


}
