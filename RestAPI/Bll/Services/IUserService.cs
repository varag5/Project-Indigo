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
		void CreateUser(UserDto user);
		void GetUserById(int id);
		void UpdateUser(int id, UserDto user);
	}
}
