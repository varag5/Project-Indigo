using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	/// <summary>
	/// Controller for all the users.
	/// </summary>
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		// POST: api/user
		/// <summary>
		/// Creates a new user.
		/// </summary>
		/// <returns></returns>
		/// <response code="201">The creation of the new user is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public IActionResult CreateUser()
		{
			return Ok("Hello World!");
		}

		//PUT: api/user/{id}
		/// <summary>
		/// Updates the specified user.
		/// </summary>
		/// <param name="id">The original id of the user</param>
		/// <returns></returns>
		[HttpPut("{id}")]
		public IActionResult UpdateUser(int id)
		{
			return Ok("Hello World!");
		}

		//GET: api/user/{id}
		/// <summary>
		/// Gets a user by id.
		/// </summary>
		/// <param name="id">The id of the user</param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public IActionResult GetUser(int id)
		{
			return Ok($"Hello! User is {id}");
		}
	}
}