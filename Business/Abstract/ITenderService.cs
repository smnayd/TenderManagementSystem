using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITenderService
    {
        List<Tender> GetAll();
        List<Tender> GetByCategoryID(int CategoryID);
        List<Tender> GetByStatusID(int StatusID);
        List<Tender> GetByUserID(int UserID);
    }
}
