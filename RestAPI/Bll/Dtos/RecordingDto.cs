using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Dtos
{
	public class RecordingDto
	{
		public long ID { get; set; }

		public ItineraryDto Itinerary { get; set; }
	}
}
