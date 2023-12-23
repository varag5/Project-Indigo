using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IItineraryService
	{
		ItineraryDto CreateNewItinerary(ItineraryDto itinerary);
		ItineraryDto GetItinerary(int userId);
		ItineraryDto GetItinerary(string start, string end);
		ItineraryDto UpdateItinerary(int id, ItineraryDto itinerary);
	}
}
