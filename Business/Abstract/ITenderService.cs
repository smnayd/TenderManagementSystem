using Entities.Concrete;
using Entities.DTOs;
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
        Tender GetByTenderID(int TenderID);
        List<Tender> GetByCategoryID(int CategoryID);
        List<Tender> GetByStatusID(int StatusID);
        List<Tender> GetByUserID(int UserID);
        List<TenderDetailDto> GetTenderDetailDtos();
    }
}
