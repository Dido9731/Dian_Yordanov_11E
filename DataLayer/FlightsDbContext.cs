using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class FlightsDbContext : DbContext
    {
        public FlightsDbContext() : base("FlightContext")
        {

        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Flight> Flights { get; set; }
    }
}
