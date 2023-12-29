using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Services.Mock
{
	public class RecordingService : IRecordingService
	{
		public RecordingDto CreateNewRecording(RecordingDto recording)
		{
			return new RecordingDto()
			{
				ID = 1,
				Itinerary = new ItineraryDto()
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

				}
			};
		}

		public RecordingDto GetRecording(int id)
		{
			return new RecordingDto()
			{
				ID = 1,
				Itinerary = new ItineraryDto()
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

				}
			};
		}

		public IEnumerable<RecordingDto> GetRecordings()
		{
			return new List<RecordingDto>()
			{
				new RecordingDto()
				{
					ID = 1,
					Itinerary = new ItineraryDto()
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

					}
				},
				new RecordingDto()
				{
					ID = 2,
					Itinerary = new ItineraryDto()
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

					}
				},
				new RecordingDto()
				{
					ID = 3,
					Itinerary = new ItineraryDto()
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

					}
				}
			};
		}
	}
}