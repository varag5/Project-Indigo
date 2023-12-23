using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IRouteService
	{
		/// <summary>
		/// Creates a new route based on the given route.
		/// </summary>
		/// <param name="route">The new route to create</param>
		/// <returns>The created route</returns>
		RouteDto CreateNewRoute(RouteDto route);
		/// <summary>
		/// Gets the route with the given route number.
		/// </summary>
		/// <param name="routeNumber">The route number</param>
		/// <returns>The route with the given route number</returns>
		RouteDto GetRoute(string routeNumber);
		/// <summary>
		/// Gets a collection of routes that match part of the given route number.
		/// </summary>
		/// <param name="routeNumber">The part of a route number</param>
		/// <returns>A collection of Routes with the route number</returns>
		IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber);
		/// <summary>
		/// Gets a collection of routes that match the given stop.
		/// </summary>
		/// <param name="stop">The required stop name</param>
		/// <returns>A collection of routes with the specified stop</returns>
		IEnumerable<RouteDto> GetRoutesByStop(string stop);
		/// <summary>
		/// Gets a collection of routes that match the given stop ID.
		/// </summary>
		/// <param name="stop">The required stop ID</param>
		/// <returns>A collection of routes with the specified stop ID.</returns>
		IEnumerable<RouteDto> GetRoutesByStopId(int stopId);
		/// <summary>
		/// Updates the route with the given id.
		/// </summary>
		/// <param name="id">The id of the updating route</param>
		/// <param name="route">The updated route</param>
		/// <returns>The updated route after update</returns>
		RouteDto UpdateRoute(int id, RouteDto route);
	}
}
