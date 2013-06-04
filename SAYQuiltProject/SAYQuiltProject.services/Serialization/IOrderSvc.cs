using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public interface IOrderSvc
    {
        void StoreOrder(Order ord);
        Order RetrieveOrder(int id);
        void UpdateOrder(Order ord);
        void DeleteOrder(Order ord);
    }
}
