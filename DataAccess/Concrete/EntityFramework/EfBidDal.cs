using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBidDal : IBidDal
    {
        public void Add(Bid entity)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Bid entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Bid Get(Expression<Func<Bid, bool>> filter)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return context.Set<Bid>().SingleOrDefault(filter)!;
            }
        }

        public List<Bid> GetAll(Expression<Func<Bid, bool>> filter = null!)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return filter == null
                    ? context.Set<Bid>().ToList()
                    : context.Set<Bid>().Where(filter).ToList();
            }
        }

        public void Update(Bid entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
