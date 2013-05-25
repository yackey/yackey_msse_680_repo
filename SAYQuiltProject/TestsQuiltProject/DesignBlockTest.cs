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
    class DesignBlockTestTest
    {
        [Test]
        public void TestDesignBlockValidate()
        {
            var designBlock = new DesignBlock();
            bool bValid = designBlock.Validate();
            Assert.IsFalse(bValid);
        }


        [Test]
        public void TestDesignBlockUpdateList()
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
                    DesignBlock modb = q.DesignBlock;
                    modb.Description = "New Description";
                    db.SaveChanges();
                    // Display all Quilts/Orders/Recipients from the database
                    var query = from dblock in db.DesignBlocks
                                orderby dblock.Description
                                select dblock;
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

