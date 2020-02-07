using Core.Data.Model.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Data.Repository.Infrastructure
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Add(T entity)
        {
            try
            {
                _dbContext.Set<T>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> All()
        {
            return _dbContext.Set<T>().ToList();
        }

        public bool Delete(T entity)
        {
            try
            {
                _dbContext.Set<T>().Remove(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                _dbContext.Entry<T>(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> Where(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().Where(where).ToList();
        }
    }
}
