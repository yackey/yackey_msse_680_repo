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
        IUnitOfWork GetInformationStoreUow();
        IRepository<Order> GetOrderInformationStore();
        bool SaveProject(String sProjectName);
        IEnumerable<Order> GetOrderList();
    }
}
