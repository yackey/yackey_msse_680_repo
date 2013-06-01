using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Order
    {
        public bool Validate()
        {
            if (StartDate == null) return false;
            if (EndDate == null) return false;
            if (Description == null) return false;
            return true;
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}
