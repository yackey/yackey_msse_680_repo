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

        private static void TryManager()
        {
            CSimpleQuiltManager qm = new CSimpleQuiltManager();

            // orders
            IEnumerable<Order> orderList = qm.GetOrders();

            foreach (var item in orderList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("Orders - Press any key to continue...");
            Console.ReadKey();

            // bom
            IEnumerable<BOM> bomList = qm.GetBoms();

            foreach (var item in bomList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("BOM - Press any key to continue...");
            Console.ReadKey();

            // recipients
            IEnumerable<Recipient> recipientList = qm.GetRecipients();

            foreach (var item in recipientList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("Recipient - Press any key to continue...");
            Console.ReadKey();

            // awards
            IEnumerable<Award> awardList = qm.GetAwards();

            foreach (var item in awardList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("Award - Press any key to continue...");
            Console.ReadKey();

            // quilts
            IEnumerable<Quilt> quiltList = qm.GetQuilts();

            foreach (var item in quiltList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("Quilt - Press any key to continue...");
            Console.ReadKey();

            // design blocks
            IEnumerable<DesignBlock> designBlockList = qm.GetDesignBlocks();

            foreach (var item in designBlockList)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("Design Block - Press any key to continue...");
            Console.ReadKey();

            // order history
            IEnumerable<OrderHistory> orderHistoryList = qm.GetOrderHistorys();

            foreach (var item in orderHistoryList)
            {
                Console.WriteLine(item.Comments);
            }
            Console.WriteLine("Order History - Press any key to continue...");
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
