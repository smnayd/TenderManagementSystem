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
    public class EfTenderDal : EfEntityRepositoryBase<Tender, TenderSystemDbContext>, ITenderDal
    {
        public List<TenderDetailDto> GetTenderDetail()
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var result = from t in context.Tenders
                             join u in context.Users!
                             on t.UserID equals u.ID
                             select new TenderDetailDto
                             {
                                 UserID = t.UserID,
                                 CategoryID = t.CategoryID,
                                 EndDate = t.EndDate,
                                 EndPrice = t.EndPrice,
                                 StartDate = t.StartDate,
                                 StartPrice = t.StartPrice,
                                 StatusID = t.StatusID,
                                 TenderID = t.TenderID,
                                 TenderNumber = t.TenderNumber,
                                 TenderTitle = t.TenderTitle
                             };
                return result.ToList();
            }
        }

        public List<TenderDetailDto> GetTenderDetails()
        {
            throw new NotImplementedException();
        }
    }
}
