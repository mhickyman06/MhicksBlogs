using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
   public interface IBlogRepostitory<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindAllByConition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
