using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IRecordingService
	{
		RecordingDto CreateNewRecording(RecordingDto recording);
		RecordingDto GetRecording(int id);
		IEnumerable<RecordingDto> GetRecordings();
	}
}
