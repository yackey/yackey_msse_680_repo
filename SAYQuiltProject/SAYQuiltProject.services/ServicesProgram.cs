using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject;

namespace SAYQuiltProject.services
{
    class ServicesProgram
    {
        static void Main(string[] args)
        {

        }

        static void TryItOut()
        {
            var db = new QulltContext();
            // Get reference to OrderRepository.
            OrderRepository orderRepo = new OrderRepository(db);

            orderRepo = (OrderRepository)SimpleRepositoryFactory.Create<IOrderRepository>(orderRepo);

            // Get all users.
            string [] includes = {""};
            //List<Order> orders = orderRepo.GetAll(includes);
            IEnumerable<Order> ol = orderRepo.GetAll(includes);

            //orderRepo.Commit();
        }
    }
}
