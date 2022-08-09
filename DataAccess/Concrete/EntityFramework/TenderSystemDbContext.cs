using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class TenderSystemDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=saturn\sqlexpress; Database=TenderSystemDatabase; Trusted_Connection=true");
           
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Bid>? Bids { get; set; }
        public DbSet<Tender>? Tenders { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Status>? Statuses { get; set; }
        public DbSet<Image>? Images { get; set; }
    }
}
