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
		/// <response code="202">The update of the user is succesful</response>
		[ProducesResponseType(StatusCodes.Status202Accepted)]
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
		/// <response code="200">The found user is returned</response>
		/// <response code="404">The user is not found</response>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("{id}")]
		public IActionResult GetUser(int id)
		{
			return Ok($"Hello! User is {id}");
		}
	}
}