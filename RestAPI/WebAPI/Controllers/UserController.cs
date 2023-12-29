using Bll.Dtos;
using Bll.Services;
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
		private readonly IUserService userService;

		public UserController(IUserService service)
		{
			userService = service;
		}

		// POST: api/user
		/// <summary>
		/// Creates a new user.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		/// <response code="201">The creation of the new user is succesful</response>
		[ProducesResponseType(StatusCodes.Status201Created)]
		[HttpPost]
		public ActionResult<UserDto> CreateUser([FromBody] UserDto user)
		{
			userService.CreateUser(user);

			return Ok("Hello World!");
		}

		//PUT: api/user/{id}
		/// <summary>
		/// Updates the specified user.
		/// </summary>
		/// <param name="id">The original id of the user</param>
		/// <param name="user"></param>
		/// <returns></returns>
		/// <response code="202">The update of the user is succesful</response>
		[ProducesResponseType(StatusCodes.Status202Accepted)]
		[HttpPut("{id}")]
		public ActionResult<UserDto> UpdateUser(int id, [FromBody] UserDto user)
		{
			userService.UpdateUser(id, user);

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
		public ActionResult<UserDto> GetUser(int id)
		{
			userService.GetUserById(id);

			return Ok($"Hello! User is {id}");
		}
	}
}