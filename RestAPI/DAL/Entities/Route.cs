using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Entities
{
	public class Route
	{
		public int ID { get; set; }
		[Required]
		public string RouteNumber { get; set; }
		[Required]
		public string Provider { get; set; }

		public ICollection<Stop> Stops { get; } = new List<Stop>();
	}
}
