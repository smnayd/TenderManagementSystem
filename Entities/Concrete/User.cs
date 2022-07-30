using Core.Entities;
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
        public long IdentityNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string? Username { get; set; }        
        [Required]
        [StringLength(30)]
        public string? Email { get; set; }
        [Required]
        public Byte[]? PasswordHash { get; set; }
        [Required]
        public Byte[]? PAsswordSalt { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}
