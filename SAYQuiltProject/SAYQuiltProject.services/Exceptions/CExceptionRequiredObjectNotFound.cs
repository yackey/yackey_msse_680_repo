using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services.Exceptions
{
    class CExceptionRequiredObjectNotFound :Exception
    {
        public CExceptionRequiredObjectNotFound(String s) 
            : base (s)
        {

        }
    }
}
