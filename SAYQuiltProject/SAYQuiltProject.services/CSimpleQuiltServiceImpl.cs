using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    class CSimpleQuiltServiceImpl : ISimpleQuiltService
    {

        public String[] GetProjectNames()
        {
            String[] sAryNames = {"fake_1, fake_2"};
            return sAryNames;
        }

        public IEnumerable<Order> GetOrderList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = {""};
                //
                ObjectContext oc = ((IObjectContextAdapter) context).ObjectContext;
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                // Get all orders.
                IEnumerable<Order> olFact = orderRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IRepository<Order> GetOrderInformationStore()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = {""};
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                return orderRepoFromFactory;
            }
        }

        public IUnitOfWork GetInformationStoreUow()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = {""};
                //
                // ObjectContext oc = ((IObjectContextAdapter) context).ObjectContext;
                ObjectContext ServiceImplOc = ((IObjectContextAdapter)context).ObjectContext;
                //////////////////////////////////////////////////
                // Repository via unit of work
                //////////////////////////////////////////////////
                UnitOfWork uow = new UnitOfWork(ServiceImplOc);
                return uow;
            }
        }

        public bool SaveProject(String sProjectName)
        {
            return true;
        }

    }
}
