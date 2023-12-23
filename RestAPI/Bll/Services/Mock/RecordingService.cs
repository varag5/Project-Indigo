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
			return new RecordingDto();
		}

		public RecordingDto GetRecording(int id)
		{
			return new RecordingDto();
		}

		public IEnumerable<RecordingDto> GetRecordings()
		{
			return new List<RecordingDto>()
			{
				new RecordingDto(),
			};
		}
	}
}
