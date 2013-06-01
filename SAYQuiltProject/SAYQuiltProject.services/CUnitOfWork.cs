using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace SAYQuiltProject.services
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ObjectContext _context;
        private OrderRepository _orders;
        private QuiltRepository _quilts;

        public UnitOfWork(ObjectContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context was not supplied");
            }
            _context = context;
        }

        public ObjectContext Context()
        {
            return _context;

        }

        #region IUnitOfWork Members
        public IRepository<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new OrderRepository(_context);
                }

                return _orders;
            }
        }

        public IRepository<Quilt> Quilts
        {
            get
            {
                if (_quilts == null)
                {
                    _quilts = new QuiltRepository(_context);
                }
                return _quilts;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
