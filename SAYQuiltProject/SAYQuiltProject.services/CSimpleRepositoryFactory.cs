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
                // serialization
                return (T)InternalRepositoryFactory<IOrderSvc, COrderSvcAdoImpl>.Create(args);
            }
            else if (typeof(T) == typeof(IOrderRepository))
            {   // order
                return (T)InternalRepositoryFactory<IOrderRepository, OrderRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IQuiltRepository))
            {   // quilt
                return (T)InternalRepositoryFactory<IQuiltRepository, QuiltRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IAwardRepository))
            {   // Award
                return (T)InternalRepositoryFactory<IAwardRepository, AwardRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IRecipientRepository))
            {   // Recipient
                return (T)InternalRepositoryFactory<IRecipientRepository, RecipientRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IBomRepository))
            {   // BOM
                return (T)InternalRepositoryFactory<IBomRepository, BomRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IDesignBlockRepository))
            {   // DesignBlock
                return (T)InternalRepositoryFactory<IDesignBlockRepository, DesignBlockRepository>.Create(args);
            }
            else if (typeof(T) == typeof(IOrderRepository))
            {   // OrderHistory
                return (T)InternalRepositoryFactory<IOrderHistoryRepository, OrderHistoryRepository>.Create(args);
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

