using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BidDetailDto:IDto
    {
        public int BidID { get; set; }
        public int TenderID { get; set; }
        public int UserID { get; set; }
        public decimal BidPrice { get; set; }
        public DateTime BidDate { get; set; }
    }
}
