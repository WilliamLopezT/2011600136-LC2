using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_ENT.Entities
{
    public class Transporte : ServicioTuristico
    {
        public int TransporteId { get; set; }
        public string NombreEmpresa { get; set; }
        public TipoTransporte Tipo { get; set; }
        public CategoriaTransporte Categoria { get; set; }

        public Transporte()
        {
            Tipo = new TipoTransporte();
            Categoria = new CategoriaTransporte();
        }
    }
}
