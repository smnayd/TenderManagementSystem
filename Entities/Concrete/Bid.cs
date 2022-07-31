using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bid:IEntity
    {
        [Key]
        public int BidID { get; set; }
        public int TenderID { get; set; }
        public int UserID { get; set; }
        public decimal BidPrice { get; set; }
        public DateTime BidDate { get; set; }
    }
}
