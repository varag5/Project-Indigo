using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Entities
{
	public class Stop
	{
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }

		public ICollection<Route> Routes { get; } = new List<Route>();
	}
}
