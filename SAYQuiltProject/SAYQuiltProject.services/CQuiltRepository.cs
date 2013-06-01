using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace SAYQuiltProject.services
{
    public class QuiltRepository : Repository<Quilt>
    {
        public QuiltRepository(ObjectContext context)
            : base(context)
        {
        }

        public override Quilt GetById(object id)
        {
            return _objectSet.SingleOrDefault(s => s.QuiltId == (int)id);
        }
    }
}
