using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Entities
{
	public class RouteStop
	{
		public int ID { get; set; }
		[Required]
		public Direction Direction { get; set; }
		[Required]
		public int Order { get; set; }
		public int RouteID { get; set; }
		public int StopID { get; set; }
	}
}
