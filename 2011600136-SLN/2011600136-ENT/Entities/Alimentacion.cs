﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_ENT.Entities
{
    public class Alimentacion : ServicioTuristico
    {
        public int AlimentacionId { get; set; }
        public string NombreEstablecimiento { get; set; }
        public CategoriaAlimentacion Categoria { get; set; }

        public Alimentacion()
        {
            Categoria = new CategoriaAlimentacion();
        }
    }
}
