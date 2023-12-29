using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Dtos
{
	public class ItineraryDto
	{
		public long ID { get; set; }
		public string Start { get; set; }
		public string End { get; set; }

		public UserDto Owner { get; set; }
	}
}
