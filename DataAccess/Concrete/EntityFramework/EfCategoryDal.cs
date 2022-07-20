using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        
        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return context.Set<Category>().SingleOrDefault()!;
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null!)
        {
            using(TenderSystemDbContext context = new TenderSystemDbContext())
            {
                return filter == null 
                    ? context.Set<Category>().ToList() 
                    : context.Set<Category>().Where(filter).ToList();
            }
        }

    }
}
