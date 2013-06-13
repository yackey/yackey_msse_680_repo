using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    class COrderManager : CSimpleManager
    {
        public void DeleteOrder(string sQuiltOrderToDelete)
        {
            // the business rule might be don't allow delete unless the order is cancelled
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");

            Order orderToDelete = simpleQuiltSvc.GetOrder(sQuiltOrderToDelete);
            if (orderToDelete == null)
            {
                // TODO throw here
            }
            IEnumerable<OrderHistory> orderHistory = simpleQuiltSvc.GetOrderHistory(orderToDelete.OrderId);

            foreach (var item in orderHistory)
            {
                // todo if it doesnt say cancelled - throw
                Console.WriteLine(item.Phase);
            }
        }
    }
}
