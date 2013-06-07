using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public interface ISimpleQuiltService
    {
        String [] GetProjectNames();
        IUnitOfWork GetInformationStore();
        bool SaveProject(String sProjectName);
    }
}
