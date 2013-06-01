using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

/*
 * Truth in advertising
 * 
 * I'll morph this pattern for my own purposes
 * But this is all based on, taken from some wierd combination of:
 * 
 * http://www.storminajar.net/2010/05/18/generic-factory-with-repositories-part-2/
 * rjonestorm
 * 
 * http://www.primaryobjects.com/CMS/Article122.aspx
 * 
 * I'll just mention this once - it is supposedly freely available.
 * But this applies to other related piece/parts
 * 
 */
namespace SAYQuiltProject.services
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> AsQueryable();
        IEnumerable<T> GetAll(string[] includes = null);
        // IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string[] includes = null);
        T GetSingle(Expression<Func<T, bool>> where, string[] includes = null);
        T GetFirst(Expression<Func<T, bool>> where, string[] includes = null);
        void Delete(T entity);
        void Add(T entity);
    }
}
