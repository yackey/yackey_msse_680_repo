using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;
using SAYQuiltProject.services.Exceptions;

namespace SAYQuiltProject.services
{
    class CSimpleQuiltServiceImpl : ISimpleQuiltService
    {

        public String[] GetProjectNames()
        {
            String[] sAryNames = {"fake_1, fake_2"};
            return sAryNames;
        }

        public Order GetOrder(string sQuiltName)
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                // Get all orders.
                IEnumerable<Order> olFact = orderRepoFromFactory.GetAll(includes);
                Order orderToDelete = null;

                foreach (var item in olFact)
                {
                    if (item.Quilt.Name.CompareTo(sQuiltName) == 0)
                    {
                        orderToDelete = item;
                        break;
                    }
                }
                if (orderToDelete == null)
                {
                    throw new CExceptionRequiredObjectNotFound(string.Format("No order for Quilt named '{0}' found",
                                                                             sQuiltName));
                }
                return orderToDelete;
            }
        }

        public IEnumerable<OrderHistory> GetOrderHistory(int nOrderId)
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = {""};
                //
                ObjectContext oc = ((IObjectContextAdapter) context).ObjectContext;
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                // Get all orders.
                IEnumerable<Order> olFact = orderRepoFromFactory.GetAll(includes);
                Order orderToUse = null;

                foreach (var item in olFact)
                {
                    if (item.OrderId == nOrderId)
                    {
                        orderToUse = item;
                        break;
                    }
                }
                IEnumerable<OrderHistory> oh = null;
                if (orderToUse != null)
                {
                    oh = orderToUse.OrderHistories;
                }
                return oh;
            }
        }

        public bool DeleteOrder(int nOrderId)
        {
            using (QulltContext db = new QulltContext())
            {
                bool bRet = false;
                var orderToDelete = (from orders in db.Orders
                                     where orders.OrderId == nOrderId
                                     select orders).Single();
                if (orderToDelete != null)
                {
                    // clean out all the piece/parts
                    Quilt xq = orderToDelete.Quilt;
                    DesignBlock xb = xq.DesignBlock;
                    Recipient xr = orderToDelete.Recipient;

                    List<OrderHistory> listOrderHistory = orderToDelete.OrderHistories.ToList();
                    foreach (var item in listOrderHistory)
                    {
                        db.OrderHistories.Remove(item);
                    }

                    List<Award> listAward = xq.Awards.ToList();
                    foreach (var item in listAward)
                    {
                        db.Awards.Remove(item);
                    }

                    List<BOM> listBom = xq.BOMs.ToList();
                    foreach (var item in listBom)
                    {
                        db.BOMs.Remove(item);
                    }

                    db.Quilts.Remove(xq);
                    db.DesignBlocks.Remove(xb);
                    db.Orders.Remove(orderToDelete);
                    db.Recipients.Remove(xr);

                    db.SaveChanges();

                    bRet = true;
                }
                return bRet;
            }
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
