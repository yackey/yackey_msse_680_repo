using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class RecipientRepository : Repository<Recipient>, IRecipientRepository
    {
        public RecipientRepository(ObjectContext context)
            : base(context)
        {
        }

        public RecipientRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override Recipient GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.RecipientId == (int)id);
        }
    }
}
