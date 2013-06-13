using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    public abstract class CSimpleManager
    {
        private CServiceByNameFactory factory = CServiceByNameFactory.GetInstance();

        protected ISimpleService GetService(String name)
        {
            return factory.GetService(name);
        }
}

}
