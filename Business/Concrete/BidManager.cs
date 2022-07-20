using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Bid> GetTenderID(int TenderID)
        {
            return _bidDal.GetAll(p=>p.TenderID == TenderID);
        }

        public List<Bid> GetUserID(int UserID)
        {
            return _bidDal.GetAll(p=>p.UserID == UserID);
        }
    }
}
