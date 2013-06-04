using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Objects;

namespace SAYQuiltProject.services
{

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected IObjectSet<T> _objectSet;

        public Repository(ObjectContext context)
        {
            _objectSet = context.CreateObjectSet<T>();
        }

        public abstract T GetById(object id);

        public IQueryable<T> AsQueryable()
        {
            return _objectSet;
        }

        public IEnumerable<T> GetAll(string[] includes)
        {
            return AsQueryable().ToList();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> filter)
        {
            return _objectSet.Where(filter);
        }

        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        public void Remove(T entity)
        {
            _objectSet.DeleteObject(entity);
        }

        public virtual void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
        }

        public T GetFirst(Expression<Func<T, bool>> where, string[] includes)
        {
            return _objectSet.First<T>(where);
        }

        public T GetSingle(Expression<Func<T, bool>> where, string[] includes)
        {
            return _objectSet.SingleOrDefault<T>(where);
        }

    }
}
