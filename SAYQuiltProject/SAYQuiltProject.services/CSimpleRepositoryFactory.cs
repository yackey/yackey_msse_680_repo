using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public static class SimpleRepositoryFactory
    {
        public static T Create<T>(params object[] args)
        {
            if (typeof(T) == typeof(IOrderSvc))
            {
                // 
                return (T)InternalRepositoryFactory<IOrderSvc, COrderSvcAdoImpl>.Create(args);
            }
            else
            {
                return default(T);
            }
        }
    }
}

