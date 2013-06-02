using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ObjectContext context) : base(context)
        {
        }

        public OrderRepository(params object[] args) : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {
            
        }

        public override Order GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.OrderId == (int)id);
        }
    }
}
