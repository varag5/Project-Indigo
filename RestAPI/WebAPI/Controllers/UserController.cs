using Bll.Dtos;
using Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService userService;

		// POST: api/user
		/// <summary>
		/// Creates a new user.
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		public ActionResult<UserDto> CreateUser([FromBody]UserDto user)
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
		public ActionResult<UserDto> UpdateUser(int id, [FromBody]UserDto user)
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
		public ActionResult<UserDto> GetUser(int id)
		{
			return Ok($"Hello! User is {id}");
		}
	}
}