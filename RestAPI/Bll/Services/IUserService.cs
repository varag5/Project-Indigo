using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
	public interface IUserService
	{
		/// <summary>
		/// Creates a new user based on the given user.
		/// </summary>
		/// <param name="user">The new user</param>
		/// <returns>The user after creation</returns>
		UserDto CreateUser(UserDto user);
		/// <summary>
		/// Gets a user by id.
		/// </summary>
		/// <param name="id">The id of the requested user.</param>
		/// <returns>The requested user</returns>
		UserDto GetUserById(int id);
		/// <summary>
		/// Updates the specified user.
		/// </summary>
		/// <param name="id">The id of the updating user</param>
		/// <param name="user">The user which it has to be updated to</param>
		/// <returns>The updated user after update</returns>
		UserDto UpdateUser(int id, UserDto user);
	}
}
