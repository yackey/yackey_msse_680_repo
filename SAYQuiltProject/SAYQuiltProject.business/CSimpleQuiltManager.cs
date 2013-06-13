using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    public class CSimpleQuiltManager : CSimpleManager
    {
        // TODO seems like there ought to be some way to 'generic' all this up
        public IEnumerable<Order> GetOrders()  
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            //ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)factory.GetService("ISimpleQuiltService");
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<Order> objList = simpleQuiltSvc.GetOrderList();
            return objList;
        }

        public IEnumerable<Award> GetAwards()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<Award> objList = simpleQuiltSvc.GetAwardList();
            return objList;
        }

        public IEnumerable<BOM> GetBoms()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<BOM> objList = simpleQuiltSvc.GetBomList();
            return objList;
        }

        public IEnumerable<Recipient> GetRecipients()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<Recipient> objList = simpleQuiltSvc.GetRecipientList();
            return objList;
        }

        public IEnumerable<DesignBlock> GetDesignBlocks()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<DesignBlock> objList = simpleQuiltSvc.GetDesignBlockList();
            return objList;
        }

        public IEnumerable<Quilt> GetQuilts()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<Quilt> objList = simpleQuiltSvc.GetQuiltList();
            return objList;
        }

        public IEnumerable<OrderHistory> GetOrderHistorys()
        {
            //CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<OrderHistory> objList = simpleQuiltSvc.GetOrderHistoryList();
            return objList;
        }
  
        // all you objects need some form of these
        public void Create(Order o)
        {
            // TODO what do you want to do here
        }

        public Order Find(int id)
        {
            // TODO call get orders and return the one
            // or your service does have a 'by id' method
            return new Order();
        }

        public void Update(Order o)
        {
            // TODO who actually does the save
            // your repo doesn't have one
            // the uow does
        }

        public void Delete(Order o)
        {
            // TODO ditto save
        }
    }
}
