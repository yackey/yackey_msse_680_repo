using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    class CSimpleQuiltManager
    {
        public IEnumerable<Order> GetOrders()   // So maybe pass the context in as a param 
        {
            string[] includes = { "" };
            CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)factory.GetService("ISimpleQuiltService");
            IEnumerable<Order> orderList = simpleQuiltSvc.GetOrderList();
            return orderList;
        }
        
        public void Create(Order o)
        {
        }

        public Order Find(int id)
        {
            return new Order();
        }

        public void Update(Order o)
        {
        }

        public void Delete(Order o)
        {
        }
    }
}
