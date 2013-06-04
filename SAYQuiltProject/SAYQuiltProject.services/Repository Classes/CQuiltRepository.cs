using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace SAYQuiltProject.services
{
    public class QuiltRepository : Repository<Quilt>, IQuiltRepository
    {
        public QuiltRepository(ObjectContext context)
            : base(context)
        {
        }

        public QuiltRepository(params object[] args)
            : base(((IObjectContextAdapter)args[0]).ObjectContext)
        {

        }

        public override Quilt GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.QuiltId == (int)id);
        }
    }
}
