using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/recording")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
		//GET: api/recording
		/// <summary>
		/// Gets all recordings.
		/// </summary>
		/// <returns></returns>
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
		[HttpPost]
		public IActionResult CreateNewRecording()
		{
			return Ok("Hello World!");
		}
	}
}
