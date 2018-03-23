using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public interface IRepository<T> where T:BaseModel
    {
        T GetSingle(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> filter);
    }
}
