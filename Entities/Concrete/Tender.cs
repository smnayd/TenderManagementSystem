using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tender : IEntity
    {
        [Key]
        public int TenderID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public int CategoryID { get; set; }
        public string? TenderTitle { get; set; }
        public int TenderNumber { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }
}
