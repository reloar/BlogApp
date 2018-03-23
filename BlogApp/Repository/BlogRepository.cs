using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public class BlogRepository<T> : IRepository<T> where T : BaseModel
    {
        private BlogAppDbContext context = new BlogAppDbContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity is null");

            var result = context.Set<T>().FirstOrDefault(t => t.ID==entity.ID);

           context.Set<T>().Remove(result);
            SaveChanges();
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> filter)
        {
            var find = context.Set<T>().Where(filter);
            return find;
        }

        public IQueryable<T> GetAll()
        {
            var CollectAll = context.Set<T>();
            return CollectAll;
        }

        public T GetSingle(int id)
        {
            var OneItem = GetAll().FirstOrDefault(g => g.ID == id);
            return OneItem;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
