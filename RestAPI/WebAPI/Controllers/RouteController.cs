using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
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
	}
}
