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
        [Required]
        public int UserID { get; set; }
        [Required]
        public int StatusID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string? TenderTitle { get; set; }
        [Required]
        public int TenderNumber { get; set; }
        [Required]
        public decimal StartPrice { get; set; }
        [Required]
        public decimal EndPrice { get; set; }
        [Required]
        public string? StartDate { get; set; }
        [Required]
        public string? EndDate { get; set; }
    }
}
