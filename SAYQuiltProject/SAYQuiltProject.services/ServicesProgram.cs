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
            TryItOut();
        }

        static void TryItOut()
        {
            using (QulltContext context = new QulltContext())

            {
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                // TODO you need to find a better example - this might be the way to go
                // UnitOfWork uow = new UnitOfWork(oc);
                // OrderRepository orderRepo = (OrderRepository)SimpleRepositoryFactory.Create<IOrderRepository>(uow);
                // IOrderRepository orderRepo = SimpleRepositoryFactory.Create<IOrderRepository>(uow);
                OrderRepository orderRepo = new OrderRepository(oc);

                // Get all orders.
                string[] includes = { "" };
                //List<Order> orders = orderRepo.GetAll(includes);
                IEnumerable<Order> ol = orderRepo.GetAll(includes);
                foreach (var item in ol)
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
