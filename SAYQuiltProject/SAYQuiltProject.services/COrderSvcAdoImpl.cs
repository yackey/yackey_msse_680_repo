using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public class COrderSvcAdoImpl : IOrderSvc
    {
        public void StoreOrder(Order ord)
        {
            Console.WriteLine("Entering StoreOrder");
        }

        public Order GetOrder(int id)
        {
            Console.WriteLine("Entering GetOrder");
            return new Order();
        }

        public void UpdateOrder(Order ord)
        {
            Console.WriteLine("Entering UpdateOrder");
        }

        public void DeleteOrder(Order ord)
        {
            Console.WriteLine("Entering DeleteOrder");
        }

    }
}
