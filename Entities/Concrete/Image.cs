using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image:IEntity
    {
        [Key]
        public int ImageID { get; set; }
        [Required]
        public int TenderID { get; set; }
        [Required]
        [StringLength(250)]
        public string? Url { get; set; }
        [Required]
        [StringLength(250)]
        public string? PublicID { get; set; }
    }
}
