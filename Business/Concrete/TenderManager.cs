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
    public class TenderManager : ITenderService
    {
        ITenderDal _tenderDal;

        public TenderManager(ITenderDal tenderDal)
        {
            _tenderDal = tenderDal;
        }

        public List<Tender> GetAll()
        {
            return _tenderDal.GetAll();
        }

        public List<Tender> GetByCategoryID(int CategoryID)
        {
            return _tenderDal.GetAll(p=>p.CategoryID==CategoryID);
        }


        public List<Tender> GetByStatusID(int StatusID)
        {
            return _tenderDal.GetAll(p=>p.StatusID==StatusID);
        }

        public List<Tender> GetByUserID(int UserID)
        {
            return _tenderDal.GetAll(p=>p.UserID==UserID);
        }
    }
}
