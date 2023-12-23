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
			throw new NotImplementedException();
		}

		public RouteDto GetRoute(string routeNumber)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByStop(string stop)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteDto> GetRoutesByStopId(int stopId)
		{
			throw new NotImplementedException();
		}

		public RouteDto UpdateRoute(int id, RouteDto route)
		{
			throw new NotImplementedException();
		}
	}
}
