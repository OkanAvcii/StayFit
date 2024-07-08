using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.UserService
{
    public interface IUserService
    {
        int Create(UserCreateDTO model);
        int Update(UserCreateDTO model, int id);
        int Delete(int id);
        UserLoginDTO GetUserByEmailWithPassword(string email, string password);
        IList<UserCreateDTO> GetAll();
        IList<UserCreateDTO> GetAllActive();
        IList<UserCreateDTO> GetByFullName(string firstName, string lastName);
    }
}
