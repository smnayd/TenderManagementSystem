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
        public long IdentityNumber { get; set; }
        public string? Username { get; set; }    
        public string? Email { get; set; }
        public Byte[]? PasswordHash { get; set; }
        public Byte[]? PAsswordSalt { get; set; }
        public bool IsAdmin { get; set; }
    }
}
