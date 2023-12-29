using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for all the recordings. A recording is created by a user by measuring one itinerary.
	/// </summary>
	[Route("api/recording")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
		private readonly IRecordingService recordingService;

		public RecordingController(IRecordingService service)
		{
			recordingService = service;
		}

		//GET: api/recording
		/// <summary>
		/// Gets all recordings.
		/// </summary>
		/// <returns></returns>
		/// <response code="200">The found recordings are returned</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[HttpGet]
		public ActionResult<IEnumerable<RecordingDto>> GetRecordings()
		{
			return recordingService.GetRecordings().ToList();
		}

		//GET: api/recording/{id}
		/// <summary>
		/// Gets the specified recording.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <response code="200">The found recording is returned</response>
		/// <response code="404">The recording is not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("{id}")]
		public ActionResult<RecordingDto> GetRecording(int id)
		{
			return recordingService.GetRecording(id);
		}

		// POST: api/recording
		/// <summary>
		/// Creates a new recording.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new recording is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public ActionResult<ItineraryDto> CreateNewRecording([FromBody]RecordingDto recording)
		{
			var rec = recordingService.CreateNewRecording(recording);
			var location = Url.Action(nameof(GetRecording), new { id = rec.ID }) ?? $"api/recording/{rec.ID}";
			return Created(location, rec);
		}
	}
}
