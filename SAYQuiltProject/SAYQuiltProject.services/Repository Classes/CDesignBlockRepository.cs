using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class DesignBlockRepository : Repository<DesignBlock>, IDesignBlockRepository
    {
        public DesignBlockRepository(ObjectContext context)
            : base(context)
        {
        }

        public DesignBlockRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override DesignBlock GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.DesignBlockId == (int)id);
        }
    }
}
