﻿using _2011600136_ENT.Entities;
using _2011600136_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_PER.Repositories
{
    public class TipoHospedajeRepository : Repository<TipoHospedaje>, ITipoHospedajeRepository
    {
        private _2011600136Context _Context;

        public TipoHospedajeRepository(_2011600136Context context)
        {
            _Context = context;
        }
    }
}
