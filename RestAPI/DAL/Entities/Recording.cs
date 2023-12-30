using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Entities
{
	public class Recording
	{
		public int ID { get; set; }
		[Required]
		public int Order { get; set; }
		public RecordingType RecordingType { get; set; }

		[Required]
		public Itinerary Itinerary { get; set; }
		public Route? Route { get; set; }
	}
}
