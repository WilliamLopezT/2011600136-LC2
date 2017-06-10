using _2011600136_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011600136_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2011600136Context _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAlimentacionRepository Alimentaciones { get; private set; } 

        public ICalificacionHospedajeRepository CalificacioneHospedajes { get; private set; }

        public ICategoriaAlimentacionRepository CategoriaAlimentaciones { get; private set; }

    public ICategoriaHospedajeRepository CategoriaHospedajes { get; private set; }

    public ICategoriaTransporteRepository CategoriaTransportes { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IComprobantePagoRepository ComprobantePagos { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IHospedajeRepository Hospedajes { get; private set; }

        public IMedioPagoRepository MedioPagos  { get; private set; }

    public IPaqueteRepository Paquetes { get; private set; }

    public IPersonaRepository Personas { get; private set; }

    public IServicioHospedajeRepository ServicioHospedaje { get; private set; }

        public IServicioTuristicoRepository ServicioTuristico { get; private set; }

        public ITipoComprobanteRepository TipoComprobante { get; private set; }

        public ITipoHospedajeRepository TipoHospedaje { get; private set; }

        public ITipoTransporteRepository TipoTransportes { get; private set; }

        public ITransporteRepository Transporte { get; private set; }

        public IVentaPaqueteRepository VentaPaquetes { get; private set; }


        private UnityOfWork()
        {
            _Context = new _2011600136Context();
            Alimentaciones = new AlimentacionRepository(_Context);
            CalificacioneHospedajes= new CalificacionHospedajeRepository(_Context);
            CategoriaAlimentaciones = new CategoriaAlimentacionRepository(_Context);
            CategoriaHospedajes = new CategoriaHospedajeRepository(_Context);
            CategoriaTransportes = new CategoriaTransporteRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            ComprobantePagos = new ComprobantePagoRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Hospedajes = new HospedajeRepository(_Context);
            MedioPagos = new MedioPagoRespository(_Context);
            Paquetes = new PaqueteRepository(_Context);
            Personas = new PersonaRepository(_Context);
            ServicioHospedaje = new ServicioHospedajeRepository(_Context);
            ServicioTuristico = new ServicioTuristicoRepository(_Context);
            TipoComprobante = new TipoComprobanteRepository(_Context);
            TipoHospedaje = new TipoHospedajeRepository(_Context);
            TipoTransportes = new TipoTransporteRepository(_Context);
            Transporte = new TransporteRepository(_Context);
            VentaPaquetes = new VentaPaqueteRepository(_Context);

        }

        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChange()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
