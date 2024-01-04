using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Entities
{
	public class RouteJourney
	{
		public int ID { get; set; }

		public Itinerary? Itinerary { get; set; }
		public Stop? Start { get; set; }
		public Stop? End { get; set; }
		public Route? Route { get; set; }
	}
}
