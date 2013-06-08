using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;
using SAYQuiltProject;

namespace SAYQuiltProject.business
{
    class BusinessProgram
    {
        static void Main(string[] args)
        {
            //TryStore();
            //TryRetrieve();
            TryManager();
        }

        static void TryManager()
        {
            CSimpleQuiltManager qm = new CSimpleQuiltManager();
            IEnumerable<Order> orderList = qm.GetOrders();

            foreach (var item in orderList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void TryStore()
        {
            CFactory factory = new CFactory();
            COrderSvcSOAPImpl soapImpl = (COrderSvcSOAPImpl)factory.GetOrderSvc();
            Order order = new Order();
            order.StartDate = "05/22/2013";
            order.EndDate = "05/31/2013";
            order.Description = "please serialize me";
            order.OrderId = 12;
            soapImpl.StoreOrder(order);
        }

        static void TryRetrieve()
        {
            CFactory factory = new CFactory();
            COrderSvcSOAPImpl soapImpl = (COrderSvcSOAPImpl)factory.GetOrderSvc();
            Order order = soapImpl.RetrieveOrder(12); ;
        }

    }
}
