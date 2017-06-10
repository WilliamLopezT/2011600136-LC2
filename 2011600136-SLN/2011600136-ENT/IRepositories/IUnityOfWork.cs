using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAlimentacionRepository Alimentaciones { get; }
        ICalificacionHospedajeRepository CalificacioneHospedajes { get; }
        ICategoriaAlimentacionRepository CategoriaAlimentaciones { get; }
        ICategoriaHospedajeRepository CategoriaHospedajes { get; }
        ICategoriaTransporteRepository CategoriaTransportes { get; }
        IClienteRepository Clientes { get; }
       // IComprobantePagoRepository ComprobantePagos { get; }
        IEmpleadoRepository Empleados { get; }
        IHospedajeRepository Hospedajes { get; }
        IMedioPagoRepository MedioPagos { get; }
       // IPaqueteRepository Paquetes { get; }
        IPersonaRepository Personas { get; }
        IServicioHospedajeRepository ServicioHospedaje { get; }
        IServicioTuristicoRepository ServicioTuristico { get; }
        //ITipoComprobanteRepository TipoComprobante { get; }
        ITipoHospedajeRepository TipoHospedaje { get; }
        ITipoTransporteRepository TipoTransportes { get; }
        ITransporteRepository Transporte { get; }
        //IVentaPaqueteRepository VentaPaquetes { get; }

        int SaveChange();


        void StateModified(object entity);
    }
}
