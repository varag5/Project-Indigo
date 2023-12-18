using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for all the recordings. A recording is created by a user by measuring one itinerary.
	/// </summary>
	[Route("api/recording")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
		//GET: api/recording
		/// <summary>
		/// Gets all recordings.
		/// </summary>
		/// <returns></returns>
		/// <response code="200">The found recordings are returned</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[HttpGet]
		public IActionResult GetRecordings()
		{
			return Ok("Hello World!");
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
		public IActionResult GetRecording(int id)
		{
			return Ok($"Hello! Recording is {id}");
		}

		// POST: api/recording
		/// <summary>
		/// Creates a new recording.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new recording is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public IActionResult CreateNewRecording()
		{
			return Ok("Hello World!");
		}
	}
}
