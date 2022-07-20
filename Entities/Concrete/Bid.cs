using Entities.Abstract;
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
        [Required]
        public int TenderID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public decimal BidPrice { get; set; }
        [Required]
        public DateTime BidDate { get; set; }
    }
}
