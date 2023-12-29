using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class TransportationContext : DbContext
	{
		public DbSet<Route> Routes { get; set; }
		public DbSet<Stop> Stops { get; set; }
		public DbSet<BoundedWalk> BoundedWalks { get; set; }
		public DbSet<Walk> Walks { get; set; }
		public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Recording> Recordings { get; set; }
        public DbSet<RouteJourney> RouteJourneys { get; set; }
        public DbSet<RouteStop> RouteStops { get; set; }

        public TransportationContext(DbContextOptions<TransportationContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


		}
	}
}