using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Services.Mock
{
	public class RouteService : IRouteService
	{
		public RouteDto CreateNewRoute(RouteDto route)
		{
			return new RouteDto();
		}

		public RouteDto GetRoute(string routeNumber)
		{
			return new RouteDto();
		}

		public IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber)
		{
			return new List<RouteDto>()
			{
				new RouteDto(),
			};
		}

		public IEnumerable<RouteDto> GetRoutesByStop(string stop)
		{
			return new List<RouteDto>()
			{
				new RouteDto(),
			};
		}

		public IEnumerable<RouteDto> GetRoutesByStopId(int stopId)
		{
			return new List<RouteDto>() 
			{ 
				new RouteDto(), 
			};
		}

		public RouteDto UpdateRoute(int id, RouteDto route)
		{
			return new RouteDto();
		}
	}
}
