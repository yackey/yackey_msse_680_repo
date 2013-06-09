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

        public IEnumerable<Quilt> GetQuiltList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IQuiltRepository quiltRepoFromFactory = SimpleRepositoryFactory.Create<IQuiltRepository>(context);
                // Get all quilts.
                IEnumerable<Quilt> olFact = quiltRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IEnumerable<Award> GetAwardList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IAwardRepository awardRepoFromFactory = SimpleRepositoryFactory.Create<IAwardRepository>(context);
                // Get all awards.
                IEnumerable<Award> olFact = awardRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IEnumerable<Recipient> GetRecipientList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IRecipientRepository recipientRepoFromFactory = SimpleRepositoryFactory.Create<IRecipientRepository>(context);
                // Get all recipients.
                IEnumerable<Recipient> olFact = recipientRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IEnumerable<BOM> GetBomList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IBomRepository bomRepoFromFactory = SimpleRepositoryFactory.Create<IBomRepository>(context);
                // Get all BOMs.
                IEnumerable<BOM> olFact = bomRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IEnumerable<OrderHistory> GetOrderHistoryList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IOrderHistoryRepository orderHistoryRepoFromFactory = SimpleRepositoryFactory.Create<IOrderHistoryRepository>(context);
                // Get all OrderHistory.
                IEnumerable<OrderHistory> olFact = orderHistoryRepoFromFactory.GetAll(includes);
                return olFact;
            }
        }

        public IEnumerable<DesignBlock> GetDesignBlockList()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IDesignBlockRepository orderHistoryRepoFromFactory = SimpleRepositoryFactory.Create<IDesignBlockRepository>(context);
                // Get all OrderHistory.
                IEnumerable<DesignBlock> olFact = orderHistoryRepoFromFactory.GetAll(includes);
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
            // TODO work out who does what on save
            return true;
        }

    }
}
