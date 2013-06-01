using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public class CFactory
    {
        public IOrderSvc GetOrderSvc()
        {
            return new COrderSvcAdoImpl();
        }
    }
}
