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
        private AwardRepository _awards;
        private BomRepository _boms;
        private RecipientRepository _recipients;
        private DesignBlockRepository _designblocks;
        private OrderHistoryRepository _orderhistorys;

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
        // order
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
        // quilt
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
        // award
        public IRepository<Award> Awards
        {
            get
            {
                if (_awards == null)
                {
                    _awards = new AwardRepository(_context);
                }
                return _awards;
            }
        }
        // recipient
        public IRepository<Recipient> Recipients
        {
            get
            {
                if (_recipients == null)
                {
                    _recipients = new RecipientRepository(_context);
                }
                return _recipients;
            }
        }
        // bom
        public IRepository<BOM> Boms
        {
            get
            {
                if (_boms == null)
                {
                    _boms = new BomRepository(_context);
                }
                return _boms;
            }
        }
        // designblock
        public IRepository<DesignBlock> DesignBlocks
        {
            get
            {
                if (_designblocks == null)
                {
                    _designblocks = new DesignBlockRepository(_context);
                }
                return _designblocks;
            }
        }
        // orderhistory
        public IRepository<OrderHistory> OrderHistorys
        {
            get
            {
                if (_orderhistorys == null)
                {
                    _orderhistorys = new OrderHistoryRepository(_context);
                }
                return _orderhistorys;
            }
        }
        //
        public void Commit()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
