﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public interface IUnitOfWork
    {
        IRepository<Order> Orders { get; }
        IRepository<Quilt> Quilts { get; }
        void Commit();
    }
}


