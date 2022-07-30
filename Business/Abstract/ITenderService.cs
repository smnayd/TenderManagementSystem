using Core.Utilities.Results;
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
        IDataResult<List<Tender>> GetAll();
        IDataResult<Tender> GetByTenderID(int TenderID);
        IDataResult<List<Tender>> GetByCategoryID(int CategoryID);
        IDataResult<List<Tender>> GetByStatusID(int StatusID);
        IDataResult<List<Tender>> GetByUserID(int UserID);
        IDataResult<List<TenderDetailDto>> GetTenderDetailDtos();
        IResult Add(Tender tender);
        IResult Update(Tender tender);
        IResult Delete(int tenderID);
    }
}
