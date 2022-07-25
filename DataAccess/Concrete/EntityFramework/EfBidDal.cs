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
    public class EfBidDal : EfEntityRepositoryBase<Bid, TenderSystemDbContext>, IBidDal
    {
        public List<BidDetailDto> GetBidDetails()
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var result = from b in context.Bids
                             join u in context.Users!
                             on b.BidID equals u.ID
                             select new BidDetailDto
                             {
                                 BidID = b.BidID,
                                 UserID = b.UserID,
                                 BidDate = b.BidDate,
                                 BidPrice = b.BidPrice,
                                 TenderID = b.TenderID
                             };
                return result.ToList();
            }
        }
    }
}
