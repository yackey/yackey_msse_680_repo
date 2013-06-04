using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class OrderHistoryRepository : Repository<OrderHistory>, IOrderHistoryRepository
    {
        public OrderHistoryRepository(ObjectContext context)
            : base(context)
        {
        }

        public OrderHistoryRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override OrderHistory GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.OrderHistoryId == (int)id);
        }
    }
}
