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
			return new RouteDto()
			{
				ID = 1,
				RouteNumber = "CreatedRouteNumber",
				Provider = "CreatedProvider",
			};
		}

		public RouteDto GetRoute(string routeNumber)
		{
			return new RouteDto()
			{
				ID = 1,
				RouteNumber = routeNumber,
				Provider = "GetRouteProvider",
			};
		}

		public IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber)
		{
			return new List<RouteDto>()
			{
				new RouteDto()
				{
					ID = 1,
					RouteNumber = routeNumber + "_1",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 2,
					RouteNumber = routeNumber + "_2",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 3,
					RouteNumber = routeNumber + "_3",
					Provider = "GetRoutesByRouteNumberProvider",
				},
			};
		}

		public IEnumerable<RouteDto> GetRoutesByStop(string stop)
		{
			return new List<RouteDto>()
			{
				new RouteDto()
				{
					ID = 1,
					RouteNumber = "GetRoutesByStopNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 2,
					RouteNumber = "GetRoutesByStopNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 3,
					RouteNumber = "GetRoutesByStopNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
			};
		}

		public IEnumerable<RouteDto> GetRoutesByStopId(int stopId)
		{
			return new List<RouteDto>()
			{
				new RouteDto()
				{
					ID = 1,
					RouteNumber = "GetRoutesByStopIdNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 2,
					RouteNumber = "GetRoutesByStopIdNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
				new RouteDto()
				{
					ID = 3,
					RouteNumber = "GetRoutesByStopIdNumber",
					Provider = "GetRoutesByRouteNumberProvider",
				},
			};
		}

		public RouteDto UpdateRoute(int id, RouteDto route)
		{
			return new RouteDto()
			{
				ID = 1,
				RouteNumber = "UpdatedRouteNumber",
				Provider = "UpdatedProvider",
			};
		}
	}
}
