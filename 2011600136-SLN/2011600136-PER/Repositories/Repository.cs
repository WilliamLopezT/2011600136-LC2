﻿using _2011600136_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_PER.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity :class
    {
    }
}
