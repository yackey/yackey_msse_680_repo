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
    class RecipientTest
    {
        [Test]
        public void TestRecipientValidate()
        {
            var recipient = new Recipient();
            bool bValid = recipient.Validate();
            Assert.IsFalse(bValid);
        }

        [Test]
        public void TestRecipientUpdateList()
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
                    Quilt q = db.Quilts.First(i => i.Name == "CreateQuiltTest Name");
                    Recipient modr = q.Order.Recipient;
                    modr.Address1 = "987 Main St";
                    db.SaveChanges();
                    // Display all Quilts/Orders/Recipients from the database
                    var query = from r in db.Recipients
                                orderby r.Address1
                                select r;
                    int item_count = 0;
                    foreach (var item in query)
                    {
                        item_count++;
                    }
                    Assert.IsTrue(item_count > 0);
                }
            }
        }
    }
}
