using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;

    public partial class BOM
    {
        public bool Validate()
        {
            if (TypeOfItem == null) return false;
            if (Count == null) return false;
            if (Description == null) return false;
            return true;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
