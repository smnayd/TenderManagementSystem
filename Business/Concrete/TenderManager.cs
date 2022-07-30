using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class TenderManager : ITenderService
    {
        ITenderDal _tenderDal;

        public TenderManager(ITenderDal tenderDal)
        {
            _tenderDal = tenderDal;
        }

        public IResult Add(Tender tender)
        {
            _tenderDal.Add(tender);
            return new SuccessResult(Messages.TenderAdded);
        }

        public IResult Delete(int tenderID)
        {
            _tenderDal.Delete(new Tender { TenderID = tenderID });
            return new SuccessResult(Messages.TenderDeleted);
        }

        public IDataResult<List<Tender>> GetAll()
        {
            return new SuccessDataResult<List<Tender>>(_tenderDal.GetAll());
        }

        public IDataResult<List<Tender>> GetByCategoryID(int CategoryID)
        {
            return new SuccessDataResult<List<Tender>>(_tenderDal.GetAll(t=>t.CategoryID==CategoryID));
        }


        public IDataResult<List<Tender>> GetByStatusID(int StatusID)
        {
            return new SuccessDataResult<List<Tender>>(_tenderDal.GetAll(t=>t.StatusID==StatusID));
        }

        public IDataResult<Tender> GetByTenderID(int TenderID)
        {
            return new SuccessDataResult<Tender>(_tenderDal.Get(t => t.TenderID == TenderID));
        }

        public IDataResult<List<Tender>> GetByUserID(int UserID)
        {
            return new SuccessDataResult<List<Tender>>(_tenderDal.GetAll(t => t.UserID == UserID));
        }

        public IDataResult<List<TenderDetailDto>> GetTenderDetailDtos()
        {
            return new SuccessDataResult<List<TenderDetailDto>>(_tenderDal.GetTenderDetails());
        }

        public IResult Update(Tender tender)
        {
            _tenderDal.Update(tender);
            return new SuccessResult(Messages.TenderUpdated);
        }
    }
}
