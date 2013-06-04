using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class AwardRepository : Repository<Award>, IAwardRepository
    {
        public AwardRepository(ObjectContext context)
            : base(context)
        {
        }

        public AwardRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override Award GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.AwardId == (int)id);
        }
    }
}
