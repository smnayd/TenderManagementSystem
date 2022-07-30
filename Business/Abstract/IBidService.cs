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
    public interface IBidService
    {
        IDataResult<List<Bid>> GetAll();
        IDataResult<Bid> GetByBidID(int BidID);
        IDataResult<List<Bid>> GetUserID(int UserID);
        IDataResult<List<Bid>> GetTenderID(int TenderID);
        IDataResult<List<BidDetailDto>> GetBidDetailDtos();
        IResult Add(Bid bid);
        IResult Update(Bid bid);
        IResult Delete(int BidID);
    }
}
