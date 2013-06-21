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

        public Recipient GetOrderRecipient(int nOrderId)
        {
            using (QulltContext db = new QulltContext())
            {
                var order = (from orders in db.Orders
                                      where orders.OrderId == nOrderId
                                      select orders).Single();

                return order.Recipient;
            }
        }

        public IEnumerable<Award> GetAwards(int nQuiltId)
        {
            using (QulltContext db = new QulltContext())
            {
                var quilt = (from quilts in db.Quilts
                             where quilts.QuiltId == nQuiltId
                             select quilts).Single();

                return quilt.Awards;
            }
        }

        public IEnumerable<BOM> GetBOM(int nQuiltId)
        {
            using (QulltContext db = new QulltContext())
            {
                var quilt = (from quilts in db.Quilts
                             where quilts.QuiltId == nQuiltId
                             select quilts).Single();

                return quilt.BOMs;
            }
        }

        public DesignBlock GetDesignBlock(int nQuiltId)
        {
            using (QulltContext db = new QulltContext())
            {
                var quilt = (from quilts in db.Quilts
                             where quilts.QuiltId == nQuiltId
                             select quilts).Single();

                return quilt.DesignBlock;
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

        // setup db
        public void SetupDb(bool bMakeCancelledHistory)
        {
            using (var db = new QulltContext())
            {
                string sName = ("CreateQuiltTest Name");
                bool bFoundQuilt = false;
                var find_query = from query_quilts in db.Quilts
                                 orderby query_quilts.Name
                                 select query_quilts;

                foreach (var item in find_query)
                {
                    if (item.Name == sName)
                    {
                        bFoundQuilt = true;
                    }
                }

                if (bFoundQuilt == true)
                {
                    Quilt xq = db.Quilts.First(i => i.Name == sName);
                    DesignBlock xb = xq.DesignBlock;
                    Order xo = xq.Order;
                    Recipient xr = xo.Recipient;

                    List<OrderHistory> listOrderHistory = xo.OrderHistories.ToList();
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
                    db.Orders.Remove(xo);
                    db.Recipients.Remove(xr);

                    db.SaveChanges();
                }

                // Create and save a new Order
                // this is the pattern for a 1 to many - yea !!!
                // Quilt
                var quilt_desc = "CreateQuiltTest Description";
                var quilt_name = "CreateQuiltTest Name";
                // Order
                var order_desc = "CreateQuiltTest Order Description";
                var order_start = "05/01/2013";
                var order_end = "05/21/2013";
                // Recipient
                var rec_fn = "Fred";
                var rec_ln = "Smith";
                var rec_a1 = "123";
                var rec_a2 = "Elm";
                var rec_type = "Individual";
                // Design Block
                var dblock_desc = "sunflower";
                var dblock_genesis = "Block of the Month Club";
                //
                var order = new Order { Description = order_desc, StartDate = order_start, EndDate = order_end };
                var quilt = new Quilt { Name = quilt_name, Description = quilt_desc };
                var recipient = new Recipient { FirstName = rec_fn, LastName = rec_ln, Address1 = rec_a1, Address2 = rec_a2, Type = rec_type };
                var dblock = new DesignBlock { Genesis = dblock_genesis, Description = dblock_desc };
                //
                var qid = quilt.QuiltId;    // do I have to mess with these ?
                var oid = order.OrderId;
                var rid = recipient.RecipientId;
                var bib = dblock.DesignBlockId;
                // 
                quilt.Order = order;
                order.Quilt = quilt;
                order.Recipient = recipient;    // this seems clumsy
                quilt.DesignBlock = dblock;
                //
                db.Orders.Add(order);
                db.Quilts.Add(quilt);
                db.Recipients.Add(recipient);
                db.DesignBlocks.Add(dblock);
                //
                var orderHistory = new OrderHistory();
                orderHistory.BeginDate = "4/16/2013";
                orderHistory.EndDate = "05/31/2013";
                orderHistory.Comments = "Delays in getting supplies";
                orderHistory.Phase = "Construction";

                order.OrderHistories.Add(orderHistory);
                db.OrderHistories.Add(orderHistory);
                //
                if (bMakeCancelledHistory == true)
                {
                    var orderHistory2 = new OrderHistory();
                    orderHistory2.BeginDate = "6/16/2013";
                    orderHistory2.EndDate = "6/16/2013";
                    orderHistory2.Comments = "No longer interested";
                    orderHistory2.Phase = "Cancelled";

                    db.OrderHistories.Add(orderHistory2);
                }
                //
                var awd = new Award();
                awd.AwardingBody = "Hancock Fabric";
                awd.DateOfAward = "5/22/2008";
                awd.Description = "Blue Ribbon";

                quilt.Awards.Add(awd);
                db.Awards.Add(awd);
                //
                var bom = new BOM();
                bom.TypeOfItem = "Border Squares";
                bom.Count = "35";
                bom.Description = "Yellow fabric with orange edges";

                quilt.BOMs.Add(bom);
                db.BOMs.Add(bom);
                //
                db.SaveChanges();
            }
        }
    }
}
