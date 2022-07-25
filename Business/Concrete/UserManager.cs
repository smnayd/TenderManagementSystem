﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<User> GetByIsAdmin(byte[] isAdmin)
        {
            return _userDal.GetAll(u => u.IsAdmin == isAdmin);
        }

        public List<UserDetailDto> GetUserDetails()
        {
            return _userDal.GetUserDetails();
        }
    }
}
