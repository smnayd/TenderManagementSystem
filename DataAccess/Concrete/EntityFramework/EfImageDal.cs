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
    public class EfImageDal : IImageDal
    {
        public void Add(Image entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Image entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Image Get(Expression<Func<Image, bool>> filter)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return context.Set<Image>().SingleOrDefault()!;
            }
        }

        public List<Image> GetAll(Expression<Func<Image, bool>> filter = null!)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return filter == null
                    ? context.Set<Image>().ToList()
                    : context.Set<Image>().Where(filter).ToList();
            }
        }

        public void Update(Image entity)
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
