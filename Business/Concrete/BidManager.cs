using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        [ValidationAspect(typeof(BidValidator))]
        public IResult Add(Bid bid)
        {           
            _bidDal.Add(bid);
            return new SuccessResult(Messages.BidAdded);
        }

        public IResult Delete(int BidID)
        {
            _bidDal.Delete(new Bid { BidID = BidID });
            return new SuccessResult(Messages.BidDeleted);
        }

        public IDataResult<List<Bid>> GetAll()
        {
            return new SuccessDataResult<List<Bid>>(_bidDal.GetAll());
        }

        public IDataResult<List<BidDetailDto>> GetBidDetailDtos()
        {
            return new SuccessDataResult<List<BidDetailDto>>(_bidDal.GetBidDetails());
        }

        public IDataResult<Bid> GetByBidID(int BidID)
        {
            return new SuccessDataResult<Bid>(_bidDal.Get(b => b.BidID == BidID));
        }

        public IDataResult<List<Bid>> GetTenderID(int TenderID)
        {
            return new SuccessDataResult<List<Bid>>(_bidDal.GetAll(b=>b.TenderID == TenderID));
        }

        public IDataResult<List<Bid>> GetUserID(int UserID)
        {
            return new SuccessDataResult<List<Bid>>(_bidDal.GetAll(b=>b.UserID == UserID));
        }

        public IResult Update(Bid bid)
        {
            _bidDal.Update(bid);
            return new SuccessResult(Messages.BidUpdated);
        }

    }
}
