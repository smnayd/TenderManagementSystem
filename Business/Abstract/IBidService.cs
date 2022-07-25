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
        List<Bid> GetAll();
        Bid GetByBidID(int BidID);
        List<Bid> GetUserID(int UserID);
        List<Bid> GetTenderID(int TenderID);
        List<BidDetailDto> GetBidDetailDtos();
    }
}
