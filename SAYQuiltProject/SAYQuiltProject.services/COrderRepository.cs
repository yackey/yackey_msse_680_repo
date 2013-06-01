using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace SAYQuiltProject.services
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(QulltContext context) : base(context)
        {
        }

        public override Order GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.OrderId == (int)id);
        }
    }
}
