using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for all the itineraries, which are defined by the users.
	/// </summary>
	[Route("api/itinerary")]
	[ApiController]
	public class ItineraryController : ControllerBase
	{
		// POST: api/itinerary
		/// <summary>
		/// Creates a new itinerary.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new itinerary is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public IActionResult CreateNewItinerary()
		{
			return Ok("Hello World!");
		}

		//PUT: api/itinerary/{id}
		/// <summary>
		/// Modify an existing itinerary.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <response code="202">The update of the itinerary is succesful</response>
		[ProducesResponseType(StatusCodes.Status202Accepted)]
		[HttpPut("{id}")]
		public IActionResult UpdateItinerary(int id)
		{
			return Ok("Hello World!");
		}

		//GET: api/itinerary/start={start}&end={end}
		/// <summary>
		/// Gets an itinerary between two locations.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		/// <response code="200">The found itinerary is returned</response>
		/// <response code="404">The itinerary is not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet]
		public IActionResult GetItinerary(string start = null, string end = null)
		{
			return Ok($"Hello! Start is {start} end is {end}");
		}

		//GET: api/itinerary/user={userId}
		/// <summary>
		/// Gets all itineraries for a user.
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <response code="200">The found itineraries are returned</response>
		/// <response code="404">The itineraries are not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("{userId}")]
		public IActionResult GetItinerary(int userId)
		{
			return Ok($"Hello! User is {userId}");
		}
	}
}
