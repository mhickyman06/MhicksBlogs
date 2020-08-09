using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MhicksBlog.Models
{
    public abstract class BlogRepositorybase<T> : IBlogRepostitory<T> where T : class
    {
        public BlogRepositorybase(BlogViewDbContext repository)
        {
            Repository = repository;
        }

        public BlogViewDbContext Repository { get; }

        public void Create(T entity)
        {
            Repository.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Repository.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return Repository.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindAllByConition(Expression<Func<T, bool>> expression)
        {
            return Repository.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            Repository.Set<T>().Update(entity);
        }
    }
}
