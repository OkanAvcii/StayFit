using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.EntityFrameworkCore;
using StayFIT_CORE.Concrete;
using StayFIT_CORE.Enums;
using StayFIT_DAL.Concrete;
using StayFIT_DAL.Interfaces;
using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo repo)
        {
            _userRepo = repo;
        }
        public int Create(UserCreateDTO model)
        {
            try
            {
                var user = new User { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, Password = model.Password, BirthDate = model.BirthDate, Height = model.Height, Weight = model.Weight, Gender = model.Gender };
                return _userRepo.Create(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Beklenmeyen bir hata gerçekleşti..." + ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                var user = _userRepo.GetById(id);
                if (user != null)
                    return _userRepo.Delete(user);
                else
                    throw new Exception("Girilen Id doğru değil");
            }
            catch (Exception ex)
            {
                throw new Exception("Beklenmeyen bir hata gerçekleşti..." + ex.Message);
            }
        }

        public IList<UserCreateDTO> GetAll()
        {
            return _userRepo.GetAll().Select(x => new UserCreateDTO { FirstName = x.FirstName, LastName = x.LastName, Email = x.Email, Password = x.Password, BirthDate = x.BirthDate, Height = x.Height, Weight = x.Weight }).ToList();
        }

        public IList<UserCreateDTO> GetAllActive()
        {
            return _userRepo.GetFilteredList(
                select: x => new UserCreateDTO { FirstName = x.FirstName, LastName = x.LastName },
                orderBy: x => x.OrderBy(x => x.FirstName));
        }

        public IList<UserCreateDTO> GetByFullName(string firstName, string lastName)
        {
            return _userRepo.GetFilteredList(
                select: x => new UserCreateDTO { FirstName = x.FirstName, LastName = x.LastName },
                where: x => x.FirstName.Contains(firstName));
        }

        public UserLoginDTO GetUserByEmailWithPassword(string email, string password)
        {
            if (_userRepo.GetAny(x => x.Email == email && x.Password == password))
            {
                var user = _userRepo.GetUserByEmail(email, password);
                var userDto = new UserLoginDTO { Email = user.Email, Password = user.Password };
                return userDto;
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public int Update(UserCreateDTO model, int id)
        {
            var user = _userRepo.GetById(id);
            if (user is not null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.Password = model.Password;
                user.Height = model.Height;
                user.Weight = model.Weight;
                user.BirthDate = model.BirthDate;
                return _userRepo.Update(user);
            }
            else
            {
                throw new Exception("Beklenmeyen bir hata gerçekleşti");
            }
        }

        //private User IsValid(string email,string password)
        //{
        //    return _userRepo.
        //}
    }
}
