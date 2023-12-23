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
		UserDto CreateUser(UserDto user);
		UserDto GetUserById(int id);
		UserDto UpdateUser(int id, UserDto user);
	}
}
