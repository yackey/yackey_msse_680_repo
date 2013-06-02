using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

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
            else if(typeof(T) == typeof(IOrderRepository))
            {
                return (T)InternalRepositoryFactory<IOrderRepository, OrderRepository>.Create(args);
            }
            else
            {
                return default(T);
            }
        }

        public static T Create<T>(ObjectContext context)
        {
            if (typeof(T) == typeof(IOrderRepository))
            {
                // 
                return (T)InternalRepositoryFactory<IOrderRepository, OrderRepository>.Create(context);
            }
            else
            {
                return default(T);
            }
        }

    }
}

