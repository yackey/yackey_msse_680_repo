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
    public partial class Recipient : IRecipient
    {
        public bool Validate()
        {
            if (FirstName == null) return false;
            if (LastName == null) return false;
            if (Address1 == null) return false;
            if (Address2 == null) return false;
            if (Type == null) return false;
            return true;
        }

        public string GetAddress()
        {
            return Address1 + " " + Address2;
        }

    }
}
