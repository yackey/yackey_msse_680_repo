using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public interface ISimpleQuiltService : ISimpleService
    {
        String [] GetProjectNames();

        Order GetOrder(string sQuiltName);
        IEnumerable<OrderHistory> GetOrderHistory(int nOrderId);
        bool DeleteOrder(int nOrderId);

        //IUnitOfWork GetInformationStoreUow();
        //IRepository<Order> GetOrderInformationStore();
        bool SaveProject(String sProjectName);

        IEnumerable<Order> GetOrderList(); 
        IEnumerable<Quilt> GetQuiltList();
        IEnumerable<Award> GetAwardList();
        IEnumerable<Recipient> GetRecipientList();
        IEnumerable<BOM> GetBomList();
        IEnumerable<OrderHistory> GetOrderHistoryList();
        IEnumerable<DesignBlock> GetDesignBlockList();

    }
}
