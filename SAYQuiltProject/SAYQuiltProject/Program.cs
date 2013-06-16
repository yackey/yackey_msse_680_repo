using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TryDeleteCreate("CreateQuiltTest Name");
            //TryDeleteCreate("CreateQuiltTest Name New");
            //TryUpdate();
        }

        // update
        static void TryUpdate()
        {
            using (var db = new QulltContext())
            {
                bool bFoundQuilt = false;
                var find_query = from query_quilts in db.Quilts
                                 orderby query_quilts.Name
                                 select query_quilts;
                foreach (var item in find_query)
                {
                    if (item.Name == "CreateQuiltTest Name")
                    {
                        bFoundQuilt = true;
                        break;
                    }
                }

                if (bFoundQuilt == true)
                {
                    Quilt modq = db.Quilts.First(i => i.Name == "CreateQuiltTest Name");
                    modq.Name = "CreateQuiltTest Name New";
                    db.SaveChanges();
                    // Display all Quilts/Orders/Recipients from the database
                    var query = from q in db.Quilts
                                orderby q.Description
                                select q;
                    Console.WriteLine("All quilts in the database:");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Name);
                    }

                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }

        // delete and create
        static void TryDeleteCreate(string sName)
        {
            using (var db = new QulltContext())
            {
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
                var bom = new BOM();
                bom.TypeOfItem = "Border Squares";
                bom.Count = "35";
                bom.Description = "Yellow fabric with orange edges";

                quilt.BOMs.Add(bom);
                db.BOMs.Add(bom);
                //
                db.SaveChanges();
                // Display all Quilts/Orders/Recipients from the database
                var query = from o in db.Orders
                            orderby o.Description
                            select o;
                Console.WriteLine("All orders in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Description);
                }

                List<BOM> listBom2 = quilt.BOMs.ToList();
                foreach (var item in listBom2)
                {
                    Console.WriteLine(item.Description);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                
                /*
                // Create and save a new Order
                
                ******    this is the pattern for doing a one to many
                
                Console.Write("Enter a name for a new Order: ");
                var desc = Console.ReadLine();
                var order = new Order { Description = desc };
                db.Orders.Add(order);

                db.SaveChanges();
                // Display all Quilts from the database
                var query = from o in db.Orders
                            orderby o.Description
                            select o;
                Console.WriteLine("All orders in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Description);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
*/
            }
        }
    }
}
