using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;

    public partial class DesignBlock
    {
        public bool Validate()
        {
            if (Genesis == null) return false;
            if (Description == null) return false;
            return true;
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}

