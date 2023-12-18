using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for the routes, which is provided by a public transport company.
	/// </summary>
	[Route("api/route")]
	[ApiController]
	public class RouteController : ControllerBase
	{
		// POST: api/route
		/// <summary>
		/// Creates a new route.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new route is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public IActionResult CreateNewRoute()
		{
			return Ok("Hello World!");
		}

		//PUT: api/route/{id}
		/// <summary>
		/// Updates the specified route.
		/// </summary>
		/// <param name="id">The original id of the route</param>
		/// <returns></returns>
		/// <response code="202">The update of the route is succesful</response>
		[ProducesResponseType(StatusCodes.Status202Accepted)]
		[HttpPut("{id}")]
		public IActionResult UpdateRoute(int id)
		{
			return Ok("Hello World!");
		}

		//GET: api/route/routeNumber={id}
		/// <summary>
		/// Gets a route by route number.
		/// </summary>
		/// <param name="routeNumber"></param>
		/// <returns></returns>
		/// <response code="200">The found route is returned</response>
		/// <response code="404">The route is not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("/routeNumber={routeNumber}")]
		public IActionResult GetRoute(int routeNumber)
		{
			return Ok($"Hello! Route is {routeNumber}");
		}

		//GET: api/route/matchRouteNumber={routeNumber}
		/// <summary>
		/// Gets all routes that match the route number.
		/// </summary>
		/// <param name="routeNumber"></param>
		/// <returns></returns>
		/// <response code="200">The found routes are returned</response>
		/// <response code="404">The routes are not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("/matchRouteNumber={routeNumber}")]
		public IActionResult GetRoutesByRouteNumber(int routeNumber)
		{
			return Ok($"Hello! Route is {routeNumber}");
		}

		//GET: api/route/stop={stop}
		/// <summary>
		/// Gets all routes that stop at the specified stop.
		/// </summary>
		/// <param name="stop"></param>
		/// <returns></returns>
		/// <response code="200">The found routes are returned</response>
		/// <response code="404">The routes are not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("/stop={stop}")]
		public IActionResult GetRoutesByStop(string stop)
		{
			return Ok($"Hello! Stop is {stop}");
		}
	}
}
