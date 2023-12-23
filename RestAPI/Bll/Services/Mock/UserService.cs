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
			throw new NotImplementedException();
		}

		public UserDto GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		public UserDto UpdateUser(int id, UserDto user)
		{
			throw new NotImplementedException();
		}
	}
}
