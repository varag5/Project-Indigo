using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Services.Mock
{
	public class ItineraryService : IItineraryService
	{
		public ItineraryDto CreateNewItinerary(ItineraryDto itinerary)
		{
			throw new NotImplementedException();
		}

		public ItineraryDto GetItinerary(int userId)
		{
			throw new NotImplementedException();
		}

		public ItineraryDto GetItinerary(string start, string end)
		{
			throw new NotImplementedException();
		}

		public ItineraryDto UpdateItinerary(int id, ItineraryDto itinerary)
		{
			throw new NotImplementedException();
		}
	}
}
