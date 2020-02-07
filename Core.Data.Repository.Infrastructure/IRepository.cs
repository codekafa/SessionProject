using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Data.Repository.Infrastructure
{
    public interface IRepository<T> where T : class, IEntity
    {
        T Get(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        List<T> All();
        List<T> Where(Expression<Func<T, bool>> where);

    }
}
