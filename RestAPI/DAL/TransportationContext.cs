using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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


		public TransportationContext() : base() { }

		public TransportationContext(DbContextOptions<TransportationContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Route>()
				.HasMany(r => r.Stops)
				.WithMany(s => s.Routes)
				.UsingEntity<RouteStop>();

			var recordingTypeConverter = new EnumToStringConverter<RecordingType>();
			modelBuilder.Entity<Recording>()
				.Property(r => r.RecordingType)
				.HasConversion(recordingTypeConverter);

			var directionTypeConverter = new EnumToStringConverter<Direction>();
			modelBuilder.Entity<RouteStop>()
				.Property(rs => rs.Direction)
				.HasConversion(directionTypeConverter);
		}
	}
}