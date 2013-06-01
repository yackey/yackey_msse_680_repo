using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    internal static class InternalRepositoryFactory<I, C> where C : I
    {
        internal static I Create(params object[] args)
        {
            return (I)Activator.CreateInstance(typeof(C), args);
        }
    }
}
