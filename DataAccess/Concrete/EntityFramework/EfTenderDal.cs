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
    public class EfTenderDal : ITenderDal
    {
        public void Add(Tender entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tender entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tender Get(Expression<Func<Tender, bool>> filter)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return context.Set<Tender>().SingleOrDefault()!;
            }
        }
        public List<Tender> GetAll(Expression<Func<Tender, bool>> filter = null!)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return filter == null
                    ? context.Set<Tender>().ToList()
                    : context.Set<Tender>().Where(filter).ToList();
            }
        }

        public void Update(Tender entity)
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
