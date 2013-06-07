using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    class ServicesProgram
    {
        static void Main(string[] args)
        {
            //TryItOut();
            TryNewFactory();
        }

        private static void TryNewFactory()
        {

            CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)factory.GetService("ISimpleQuiltService");
            String[]  sAry = simpleQuiltSvc.GetProjectNames();
            String s1 = sAry[0];
            Console.WriteLine("s1 said {0}", s1);
        }

        static void TryItOut()
        {
            using (QulltContext context = new QulltContext())

            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;

                //////////////////////////////////////////////////
                // Repository via unit of work
                //////////////////////////////////////////////////
                UnitOfWork uow = new UnitOfWork(oc);
                OrderRepository orderRepoUow = (OrderRepository)uow.Orders;
                // Get all orders.
                Console.WriteLine("Getting orders via unit of work pattern.");
                IEnumerable<Order> olUow = orderRepoUow.GetAll(includes);
                foreach (var item in olUow)
                {
                    Console.WriteLine(item.Description);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                //////////////////////////////////////////////////
                // Repository via plain old factory
                //////////////////////////////////////////////////
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                // Get all orders.
                Console.WriteLine("Getting orders via factory.");
                IEnumerable<Order> olFact = orderRepoFromFactory.GetAll(includes);
                foreach (var item in olFact)
                {
                    Console.WriteLine(item.Description);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                //////////////////////////////////////////////////
                // Repository just ordinary instanciation
                //////////////////////////////////////////////////
                OrderRepository orderRepo = new OrderRepository(oc);
                // Get all orders.
                IEnumerable<Order> olNew = orderRepo.GetAll(includes);
                foreach (var item in olNew)
                {
                    Console.WriteLine(item.Description);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                //orderRepo.Commit();
            }
        }
    }
}
