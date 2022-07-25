using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TenderSystemDbContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var result = from u in context.Users!
                             join t in context.Tenders! 
                             on u.ID equals t.UserID
                             select new UserDetailDto
                             {
                                 ID = u.ID,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                             };
                return result.ToList();
            }
        }
    }
}
