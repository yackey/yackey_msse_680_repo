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
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService) GetService("ISimpleQuiltService");
            Order orderToDelete = null;
            try
            {
                orderToDelete = simpleQuiltSvc.GetOrder(sQuiltOrderToDelete);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                return;
            }

            IEnumerable<OrderHistory> orderHistory = simpleQuiltSvc.GetOrderHistory(orderToDelete.OrderId);

            bool bIsCancelled = false;
            foreach (var item in orderHistory)
            {
                if (item.Phase.CompareTo("Cancelled") == 0)
                {
                    bIsCancelled = true;
                    break;
                }
            }
            if (bIsCancelled == false)
            {
                Console.WriteLine("The order has not been cancelled and cannot be deleted.");
            }
            else
            {
                bool bRet = simpleQuiltSvc.DeleteOrder(orderToDelete.OrderId);
            }
        }
    }
}
