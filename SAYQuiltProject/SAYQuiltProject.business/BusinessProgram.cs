using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    class BusinessProgram
    {
        private static bool bDbInitDone = true;
        static void Main(string[] args)
        {
            if (bDbInitDone == false)
            {
                TryDeleteCreate();
                bDbInitDone = true;
            }
            //TryStore();
            //TryRetrieve();
            //TryManager();
            TryOrderManager();
        }

        private static void TryOrderManager()
        {
            COrderManager om = new COrderManager();
            om.DeleteOrder("CreateQuiltTest Name");
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

        static void TryDeleteCreate()
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
                var dblock_genesis = "CreateQuiltTest Name";
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
