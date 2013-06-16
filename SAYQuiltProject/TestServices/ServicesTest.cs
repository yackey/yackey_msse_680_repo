﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using SAYQuiltProject;
using SAYQuiltProject.services;

using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace TestServices
{
    [TestFixture]
    class ServicesTest
    {
        public static bool IsSetup = false;

        //[SetUp]
        public void SetupServicesTest()
        {
            if (IsSetup == false)
            {
                TryDeleteCreate("CreateQuiltTest Name");
                IsSetup = true;
            }
        }

        [Test]
        public void ServiceViaAppConfig()
        {
            CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)factory.GetService("ISimpleQuiltService");
            IEnumerable<Order> objList = simpleQuiltSvc.GetOrderList();
            // the test is to fetch the service by name thru the app config file
            //  if any object list comes back then that worked
            int nItemCount = objList.Count();
            Assert.IsTrue(nItemCount >= 0);
        }

        [Test]
        public void ServiceExceptionNoService()
        {
            bool bCaught = false;
            ISimpleQuiltService simpleQuiltSvc = null;
            CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            try
            {
                simpleQuiltSvc = (ISimpleQuiltService) factory.GetService("ISimpleQuiltServiceNoWay");
            }
            catch (Exception e)
            {
                bCaught = true;
            }
            Assert.IsTrue(bCaught);
        }

        //[Test]
        public void ServiceViaAppConfigUow()
        {
            SetupServicesTest();

            using (QulltContext context = new QulltContext())
            {
                CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
                IUnitOfWork simpleUow = (IUnitOfWork)factory.GetService("IUnitOfWork");
                IEnumerable<Order> objList = simpleUow.GetOrderList();
                // the test is to fetch the service by name thru the app config file
                //  if any object list comes back then that worked
                int nItemCount = objList.Count();
                Assert.IsTrue(nItemCount >= 0);
            }
        }

        [Test]
        public void ServiceRepoViaRepoFactory()
        {
            SetupServicesTest();

            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;

                //////////////////////////////////////////////////
                // Repository via repo factory
                //////////////////////////////////////////////////
                IOrderRepository orderRepoFromFactory = SimpleRepositoryFactory.Create<IOrderRepository>(context);
                // Get all orders.
                int items = 0;
                IEnumerable<Order> olFact = orderRepoFromFactory.GetAll(includes);
                foreach (var item in olFact)
                {
                    items++;
                }
                Assert.IsTrue(items > 0);
            }
        }

        [Test]
        public void ServiceRepoViaNew()
        {
            SetupServicesTest();

            using (QulltContext context = new QulltContext())
            {
                string[] includes = { "" };
                //
                ObjectContext oc = ((IObjectContextAdapter)context).ObjectContext;

                //////////////////////////////////////////////////
                // Repository just ordinary instantiation
                //////////////////////////////////////////////////
                OrderRepository orderRepo = new OrderRepository(oc);
                // Get all orders.
                int items = 0;
                IEnumerable<Order> olNew = orderRepo.GetAll(includes);
                foreach (var item in olNew)
                {
                    items++;
                }
                Assert.IsTrue(items > 0);
            }
        }

        /////////////////////////////////////////
        // delete and create - called fromsetup
        /////////////////////////////////////////
        private void TryDeleteCreate(string sName)
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

                int items = 0;
                foreach (var item in query)
                {
                    items++;
                }
                //Assert.IsTrue(items > 0);
            }
        }
    }
}
