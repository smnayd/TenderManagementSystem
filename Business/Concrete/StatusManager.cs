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
    public class StatusManager : IStatusService
    {
        IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public List<Status> GetAll()
        {
            return _statusDal.GetAll();
        }
    }
}
