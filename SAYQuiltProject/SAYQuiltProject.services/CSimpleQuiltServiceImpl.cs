using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    class CSimpleQuiltServiceImpl : ISimpleQuiltService
    {
        public String[] GetProjectNames()
        {
            String[] sAryNames = {"fake_1, fake_2"};
            return sAryNames;
        }

        public IUnitOfWork GetInformationStore()
        {
            using (QulltContext context = new QulltContext())
            {
                string[] includes = {""};
                //
                ObjectContext oc = ((IObjectContextAdapter) context).ObjectContext;
                //////////////////////////////////////////////////
                // Repository via unit of work
                //////////////////////////////////////////////////
                UnitOfWork uow = new UnitOfWork(oc);
                return uow;
            }
        }

        public bool SaveProject(String sProjectName)
        {
            return true;
        }

    }
}
