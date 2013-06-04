using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class BomRepository : Repository<BOM>, IBomRepository
    {
        public BomRepository(ObjectContext context)
            : base(context)
        {
        }

        public BomRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override BOM GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.BomId == (int)id);
        }
    }
}
