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
		/// <summary>
		/// Creates a new itinerary based on the given itinerary.
		/// </summary>
		/// <param name="itinerary">The itinerary to create</param>
		/// <returns>The newly created itinerary</returns>
		ItineraryDto CreateNewItinerary(ItineraryDto itinerary);
		/// <summary>
		/// Gets all the itineraries for a given user.
		/// </summary>
		/// <param name="userId">The id of the user.</param>
		/// <returns>A collection of the itineraries with the given user</returns>
		IEnumerable<ItineraryDto> GetItinerary(int userId);
		/// <summary>
		/// Gets the itinerary with the given start and/or end locations.
		/// </summary>
		/// <param name="start">The start of the itinerary</param>
		/// <param name="end">The end of the itinerary</param>
		/// <returns>A Collection of itineraries with the given start and/or end locations</returns>
		IEnumerable<ItineraryDto> GetItinerary(string start, string end);
		/// <summary>
		/// Updates the itinerary with the given id.
		/// </summary>
		/// <param name="id">The id of the itinerary to update</param>
		/// <param name="itinerary">The new itinerary, which the old one need to be updated</param>
		/// <returns>The updated itinerary</returns>
		ItineraryDto UpdateItinerary(int id, ItineraryDto itinerary);
	}
}
