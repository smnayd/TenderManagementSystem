using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(11)]
        public int IdentityNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string? Email { get; set; }
        [Required]
        [StringLength(15)]
        public string? Password { get; set; }
        [Required]
        public byte[]? IsAdmin { get; set; }
    }
}
