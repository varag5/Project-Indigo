using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Entities
{
	public class Itinerary
	{
		public int ID { get; set; }
		[Required]
		public string Start { get; set; }
		[Required]
		public string End { get; set; }
	}
}
