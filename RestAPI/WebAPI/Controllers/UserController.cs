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
			var cu = userService.CreateUser(user);
			var location = Url.Action(nameof(GetUser), new { id = cu.ID }) ?? $"api/user/{cu.ID}";

			return Created(location, cu);
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
			return Accepted(userService.UpdateUser(id, user));
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
			return userService.GetUserById(id);
		}
	}
}