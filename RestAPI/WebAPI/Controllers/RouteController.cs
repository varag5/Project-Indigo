using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for the routes, which is provided by a public transport company.
	/// </summary>
	[Route("api/route")]
	[ApiController]
	public class RouteController : ControllerBase
	{
		private readonly IRouteService routeService;

		public RouteController(IRouteService service)
		{
			routeService = service;
		}

		// POST: api/route
		/// <summary>
		/// Creates a new route.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new route is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public ActionResult<RouteDto> CreateNewRoute([FromBody]RouteDto route)
		{
			var r = routeService.CreateNewRoute(route);
			var location = Url.Action(nameof(GetRoute), new { id = r.ID }) ?? $"api/route/{r.ID}";

			return Created(location, r);
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
		public ActionResult<RouteDto> UpdateRoute(int id, [FromBody]RouteDto route)
		{
			return Accepted(routeService.UpdateRoute(id, route));
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
		public ActionResult<RouteDto> GetRoute(string routeNumber)
		{
			return routeService.GetRoute(routeNumber);
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
		public ActionResult<IEnumerable<RouteDto>> GetRoutesByRouteNumber(string routeNumber)
		{
			return routeService.GetRoutesByRouteNumber(routeNumber).ToList();
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
		public ActionResult<IEnumerable<RouteDto>> GetRoutesByStop(string stop)
		{
			return routeService.GetRoutesByStop(stop).ToList();
		}

		//GET: api/route/stopId={stop}
		/// <summary>
		/// Gets all routes that stop at the specified stop.
		/// </summary>
		/// <param name="stopId"></param>
		/// <returns></returns>
		[HttpGet("/stopId={stop}")]
		public ActionResult<IEnumerable<RouteDto>> GetRoutesByStop(int stopId)
		{
			return routeService.GetRoutesByStopId(stopId).ToList();
		}
	}
}
