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
		RouteDto CreateNewRoute(RouteDto route);
		RouteDto GetRoute(string routeNumber);
		IEnumerable<RouteDto> GetRoutesByRouteNumber(string routeNumber);
		IEnumerable<RouteDto> GetRoutesByStop(string stop);
		IEnumerable<RouteDto> GetRoutesByStopId(int stopId);
		RouteDto UpdateRoute(int id, RouteDto route);
	}
}
