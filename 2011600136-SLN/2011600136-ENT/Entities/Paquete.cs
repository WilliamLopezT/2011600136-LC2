﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_ENT.Entities
{
    public class Paquete
    {
        public List<ServicioTuristico> Servicios { get; set; }

        public Paquete()
        {
            Servicios = new List<ServicioTuristico>();
        }
    }
}
