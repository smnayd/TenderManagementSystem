using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Status : IEntity
    {
        [Key]
        public int StatusID { get; set; }
        public string? State { get; set; }
    }
}
