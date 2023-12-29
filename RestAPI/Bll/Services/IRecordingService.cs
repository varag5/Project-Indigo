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
		/// <summary>
		/// Creates a new recording based on the given recording.
		/// </summary>
		/// <param name="recording">The recording to create</param>
		/// <returns>The created recording</returns>
		RecordingDto CreateNewRecording(RecordingDto recording);
		/// <summary>
		/// Gets the recording with the given id.
		/// </summary>
		/// <param name="id">The id of the requested recording</param>
		/// <returns>The requested recording.</returns>
		/// <exception cref="KeyNotFoundException">Thrown if the recording with the given id does not exist.</exception>
		RecordingDto GetRecording(int id);
		/// <summary>
		/// Gets all the exsisting recordings.
		/// </summary>
		/// <returns>A collection of the recordings</returns>
		IEnumerable<RecordingDto> GetRecordings();
	}
}
