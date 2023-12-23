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
		void CreateNewRoute(RouteDto route);
		void GetRoute(string routeNumber);
		void GetRoutesByRouteNumber(string routeNumber);
		void GetRoutesByStop(string stop);
		void GetRoutesByStopId(int stopId);
		void UpdateRoute(int id, RouteDto route);
	}
}
