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
		void CreateNewItinerary(ItineraryDto itinerary);
		void GetItinerary(int userId);
		void GetItinerary(string start, string end);
		void UpdateItinerary(int id, ItineraryDto itinerary);
	}
}
