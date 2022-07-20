﻿using DataAccess.Abstract;
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
    public class EfStatusDal : IStatusDal
    {
        public void Add(Status entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Status entity)
        {
            using (TenderSystemDbContext context = new TenderSystemDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Status Get(Expression<Func<Status, bool>> filter)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return context.Set<Status>().SingleOrDefault()!;
            }
        }

        public List<Status> GetAll(Expression<Func<Status, bool>> filter = null!)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return filter == null
                    ? context.Set<Status>().ToList()
                    : context.Set<Status>().Where(filter).ToList();
            }
        }

        public void Update(Status entity)
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
