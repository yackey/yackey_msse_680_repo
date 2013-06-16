using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SAYQuiltProject;

namespace TestsQuiltProject
{
    [TestFixture]
    class QuiltTest
    {
        [Test]
        public void TestQuiltValidate()
        {
            var quilt = new Quilt();
            bool bValid = quilt.Validate();
            Assert.IsFalse(bValid);
        }

        [Test]
        public void TestQuiltDeleteCreate()
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
                        }
                    }

                    if (bFoundQuilt == true)
                    {
                        Quilt xq = db.Quilts.First(i => i.Name == "CreateQuiltTest Name");
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

                    // Create and save a new quilt et al
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
                    //
                    db.SaveChanges();
                    // 
                    // Display all Quilts from the database
                    bool bFoundName = false;
                    var query = from q in db.Quilts
                                orderby q.Name
                                select q;
                    // it should be there
                    foreach (var item in query)
                    {
                        if (item.Name == "CreateQuiltTest Name")
                        {
                            bFoundName = true;
                        }
                    }
                    Assert.IsTrue(bFoundName);
            }
        }

        [Test]
        public void TestQuiltUpdateList()
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

                Assert.IsTrue(bFoundQuilt);

                if (bFoundQuilt == true)
                {
                    Quilt modq = db.Quilts.First(i => i.Name == "CreateQuiltTest Name");
                    modq.Name = "CreateQuiltTest Name New";
                    db.SaveChanges();
                    // Display all Quilts/Orders/Recipients from the database
                    var query = from q in db.Quilts
                                orderby q.Description
                                select q;
                    int item_count = 0;
                    foreach (var item in query)
                    {
                        item_count++;
                    }
                    Assert.IsTrue(item_count > 0);
                    // put it back
                    Quilt modq_2 = db.Quilts.First(i => i.Name == "CreateQuiltTest Name New");
                    modq_2.Name = "CreateQuiltTest Name";
                    db.SaveChanges();
                }
            }
        }
    }
}
