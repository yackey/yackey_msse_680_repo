using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject
{
    using System;
    using System.Collections.Generic;

    public partial class OrderHistory : IOrderHistory
    {
        public bool Validate()
        {
            if (Phase == null) return false;
            if (BeginDate == null) return false;
            if (EndDate == null) return false;
            if (Comments == null) return false;
            return true;
        }

        public string GetComments()
        {
            return Comments;
        }

    }
}
