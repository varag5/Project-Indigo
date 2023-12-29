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
			return new ItineraryDto()
			{
				ID = 1,
				Start = "CreatedStart",
				End = "CreatedEnd",
				Owner = new UserDto()
				{
					ID = 1,
					Username = "user",
					Password = "password",
				}
			};
		}

		public IEnumerable<ItineraryDto> GetItinerary(int userId)
		{
			return new List<ItineraryDto>()
			{
				new ItineraryDto()
				{
					ID = 1,
					Start = "GetByUserStart",
					End = "GetByUserEnd",
					Owner = new UserDto()
					{
						ID = userId,
						Username = "user",
						Password = "password",
					}
				},
				new ItineraryDto()
				{
					ID = 2,
					Start = "GetByUserStart",
					End = "GetByUserEnd",
					Owner = new UserDto()
					{
						ID = userId,
						Username = "user",
						Password = "password",
					}
				},
				new ItineraryDto()
				{
					ID = 3,
					Start = "GetByUserStart",
					End = "GetByUserEnd",
					Owner = new UserDto()
					{
						ID = userId,
						Username = "user",
						Password = "password",
					}
				},
			};
		}

		public IEnumerable<ItineraryDto> GetItinerary(string start, string end)
		{
			return new List<ItineraryDto>()
			{
				new ItineraryDto()
				{
					ID = 1,
					Start = start,
					End = end,
					Owner = new UserDto()
					{
						ID = 1,
						Username = "user",
						Password = "password",
					}
				},
				new ItineraryDto()
				{
					ID = 2,
					Start = start,
					End = end,
					Owner = new UserDto()
					{
						ID = 1,
						Username = "user",
						Password = "password",
					}
				},
				new ItineraryDto()
				{
					ID = 3,
					Start = start,
					End = end,
					Owner = new UserDto()
					{
						ID = 1,
						Username = "user",
						Password = "password",
					}
				},
			};
		}

		public ItineraryDto UpdateItinerary(int id, ItineraryDto itinerary)
		{
			return new ItineraryDto()
			{
				ID = 1,
				Start = "UpdatedStart",
				End = "UpdatedEnd",
				Owner = new UserDto()
				{
					ID = 1,
					Username = "user",
					Password = "password",
				}
			};
		}
	}
}
