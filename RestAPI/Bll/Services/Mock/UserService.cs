using Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Services.Mock
{
	public class UserService : IUserService
	{
		public UserDto CreateUser(UserDto user)
		{
			return new UserDto();
		}

		public UserDto GetUserById(int id)
		{
			return new UserDto();
		}

		public UserDto UpdateUser(int id, UserDto user)
		{
			return new UserDto();
		}
	}
}
