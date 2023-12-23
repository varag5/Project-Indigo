using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
	[Route("api/route")]
	[ApiController]
	public class RouteController : ControllerBase
	{
		private readonly IRouteService routeService;

		// POST: api/route
		/// <summary>
		/// Creates a new route.
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		public ActionResult<RouteDto> CreateNewRoute([FromBody]RouteDto route)
		{
			routeService.CreateNewRoute(route);

			return Ok("Hello World!");
		}

		//PUT: api/route/{id}
		/// <summary>
		/// Updates the specified route.
		/// </summary>
		/// <param name="id">The original id of the route</param>
		/// <returns></returns>
		[HttpPut("{id}")]
		public ActionResult<RouteDto> UpdateRoute(int id, [FromBody]RouteDto route)
		{
			routeService.UpdateRoute(id, route);

			return Ok("Hello World!");
		}

		//GET: api/route/routeNumber={id}
		/// <summary>
		/// Gets a route by route number.
		/// </summary>
		/// <param name="routeNumber"></param>
		/// <returns></returns>
		[HttpGet("/routeNumber={routeNumber}")]
		public ActionResult<RouteDto> GetRoute(string routeNumber)
		{
			routeService.GetRoute(routeNumber);

			return Ok($"Hello! Route is {routeNumber}");
		}

		//GET: api/route/matchRouteNumber={routeNumber}
		/// <summary>
		/// Gets all routes that match the route number.
		/// </summary>
		/// <param name="routeNumber"></param>
		/// <returns></returns>
		[HttpGet("/matchRouteNumber={routeNumber}")]
		public ActionResult<IEnumerable<RouteDto>> GetRoutesByRouteNumber(string routeNumber)
		{
			routeService.GetRoutesByRouteNumber(routeNumber);

			return Ok($"Hello! Route is {routeNumber}");
		}

		//GET: api/route/stop={stop}
		/// <summary>
		/// Gets all routes that stop at the specified stop.
		/// </summary>
		/// <param name="stop"></param>
		/// <returns></returns>
		[HttpGet("/stop={stop}")]
		public ActionResult<IEnumerable<RouteDto>> GetRoutesByStop(string stop)
		{
			routeService.GetRoutesByStop(stop);

			return Ok($"Hello! Stop is {stop}");
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
			routeService.GetRoutesByStopId(stopId);

			return Ok($"Hello! Stop is {stopId}");
		}
	}
}
