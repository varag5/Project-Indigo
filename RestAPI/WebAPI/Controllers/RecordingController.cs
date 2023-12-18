using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	[Route("api/recording")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
		private readonly IRecordingService recordingService;

		//GET: api/recording
		/// <summary>
		/// Gets all recordings.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult<IEnumerable<RecordingDto>> GetRecordings()
		{
			return Ok("Hello World!");
		}

		//GET: api/recording/{id}
		/// <summary>
		/// Gets the specified recording.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public ActionResult<RecordingDto> GetRecording(int id)
		{
			return Ok($"Hello! Recording is {id}");
		}

		// POST: api/recording
		/// <summary>
		/// Creates a new recording.
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		public ActionResult<ItineraryDto> CreateNewRecording([FromBody]RecordingDto recording)
		{
			return Ok("Hello World!");
		}
	}
}
