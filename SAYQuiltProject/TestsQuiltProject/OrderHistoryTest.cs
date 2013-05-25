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
    class OrderHistoryTest
    {
        [Test]
        public void TestOrderHistoryValidate()
        {
            var orderHistory = new OrderHistory();
            bool bValid = orderHistory.Validate();
            Assert.IsFalse(bValid);
        }
    }
}