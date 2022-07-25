using Business.Abstract;
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
    public class BidManager : IBidService
    {
        IBidDal _bidDal;

        public BidManager(IBidDal bidDal)
        {
            _bidDal = bidDal;
        }

        public List<Bid> GetAll()
        {
            return _bidDal.GetAll();
        }

        public List<BidDetailDto> GetBidDetailDtos()
        {
            return _bidDal.GetBidDetails();
        }

        public Bid GetByBidID(int BidID)
        {
            return _bidDal.Get(b => b.BidID == BidID);
        }

        public List<Bid> GetTenderID(int TenderID)
        {
            return _bidDal.GetAll(b=>b.TenderID == TenderID);
        }

        public List<Bid> GetUserID(int UserID)
        {
            return _bidDal.GetAll(b=>b.UserID == UserID);
        }
    }
}
