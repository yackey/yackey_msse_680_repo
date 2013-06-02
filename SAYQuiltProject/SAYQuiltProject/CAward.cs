using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;

    public partial class Award : IAward
    {
        public bool Validate()
        {
            if (AwardingBody == null) return false;
            if (DateOfAward == null) return false;
            if (Description == null) return false; 
            return true;
        }

        public string GetDescription()
        {
            return Description;
        }

    }
}
