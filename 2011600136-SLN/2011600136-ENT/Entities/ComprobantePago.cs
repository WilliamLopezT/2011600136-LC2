using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_ENT.Entities
{
    public class ComprobantePago
    {
        public int TipoComprobanteId { get; set; }
        public TipoComprobante TipoComprobante { get; set; }

        public ComprobantePago()
        {
            TipoComprobante = new TipoComprobante();
        }
    }
}
