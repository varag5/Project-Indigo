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
		[HttpGet("/stop={stop}")]
		public IActionResult GetRoutesByStop(string stop)
		{
			return Ok($"Hello! Stop is {stop}");
		}
	}
}
