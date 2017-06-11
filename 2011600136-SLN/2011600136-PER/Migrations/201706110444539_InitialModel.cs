namespace _2011600136_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServicioTuristicoes",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(),
                        AlimentacionId = c.Int(),
                        NombreEstablecimiento = c.String(),
                        HospedajeId = c.Int(),
                        NombreAlojamiento = c.String(),
                        TransporteId = c.Int(),
                        NombreEmpresa = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Categoria_CategoriaAlimentacionId = c.Int(),
                        Calificacion_CalificacionHospedajeId = c.Int(),
                        Categoria_CategoriaHospedajeId = c.Int(),
                        Servicio_ServicioHospedajeId = c.Int(),
                        Tipo_TipoHospedajeId = c.Int(),
                        Categoria_CategoriaTransporteId = c.Int(),
                        Tipo_TipoTransporteId = c.Int(),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId)
                .ForeignKey("dbo.CategoriaAlimentacions", t => t.Categoria_CategoriaAlimentacionId)
                .ForeignKey("dbo.CalificacionHospedajes", t => t.Calificacion_CalificacionHospedajeId)
                .ForeignKey("dbo.CategoriaHospedajes", t => t.Categoria_CategoriaHospedajeId)
                .ForeignKey("dbo.ServicioHospedajes", t => t.Servicio_ServicioHospedajeId)
                .ForeignKey("dbo.TipoHospedajes", t => t.Tipo_TipoHospedajeId)
                .ForeignKey("dbo.CategoriaTransportes", t => t.Categoria_CategoriaTransporteId)
                .ForeignKey("dbo.TipoTransportes", t => t.Tipo_TipoTransporteId)
                .Index(t => t.Categoria_CategoriaAlimentacionId)
                .Index(t => t.Calificacion_CalificacionHospedajeId)
                .Index(t => t.Categoria_CategoriaHospedajeId)
                .Index(t => t.Servicio_ServicioHospedajeId)
                .Index(t => t.Tipo_TipoHospedajeId)
                .Index(t => t.Categoria_CategoriaTransporteId)
                .Index(t => t.Tipo_TipoTransporteId);
            
            CreateTable(
                "dbo.CategoriaAlimentacions",
                c => new
                    {
                        CategoriaAlimentacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaAlimentacionId);
            
            CreateTable(
                "dbo.CalificacionHospedajes",
                c => new
                    {
                        CalificacionHospedajeId = c.Int(nullable: false, identity: true),
                        DescripcionCalificacion = c.String(),
                    })
                .PrimaryKey(t => t.CalificacionHospedajeId);
            
            CreateTable(
                "dbo.CategoriaHospedajes",
                c => new
                    {
                        CategoriaHospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaHospedajeId);
            
            CreateTable(
                "dbo.CategoriaTransportes",
                c => new
                    {
                        CategoriaTransporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaTransporteId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        DNIPersona = c.Int(nullable: false),
                        DireccionPersona = c.String(),
                        EdadPersona = c.Int(nullable: false),
                        TelefonoPersona = c.Int(nullable: false),
                        ClienteId = c.Int(),
                        EmpleadoId = c.Int(),
                        TipoEmpleado = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.ServicioHospedajes",
                c => new
                    {
                        ServicioHospedajeId = c.Int(nullable: false, identity: true),
                        Comida = c.String(),
                        Bebidas = c.String(),
                        Postre = c.String(),
                    })
                .PrimaryKey(t => t.ServicioHospedajeId);
            
            CreateTable(
                "dbo.TipoHospedajes",
                c => new
                    {
                        TipoHospedajeId = c.Int(nullable: false, identity: true),
                        NombreHospedaje = c.String(),
                    })
                .PrimaryKey(t => t.TipoHospedajeId);
            
            CreateTable(
                "dbo.MedioPagoes",
                c => new
                    {
                        MedioPagoId = c.Int(nullable: false, identity: true),
                        TipoPago = c.String(),
                        TipoTarjeta = c.String(),
                        NombreBanco = c.String(),
                    })
                .PrimaryKey(t => t.MedioPagoId);
            
            CreateTable(
                "dbo.TipoTransportes",
                c => new
                    {
                        TipoTransporteId = c.Int(nullable: false, identity: true),
                        NombreTransporte = c.String(),
                    })
                .PrimaryKey(t => t.TipoTransporteId);
            
            CreateTable(
                "dbo.TipoComprobantes",
                c => new
                    {
                        TipoComprobanteId = c.Int(nullable: false, identity: true),
                        NombreComprobante = c.String(),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoComprobanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicioTuristicoes", "Tipo_TipoTransporteId", "dbo.TipoTransportes");
            DropForeignKey("dbo.ServicioTuristicoes", "Categoria_CategoriaTransporteId", "dbo.CategoriaTransportes");
            DropForeignKey("dbo.ServicioTuristicoes", "Tipo_TipoHospedajeId", "dbo.TipoHospedajes");
            DropForeignKey("dbo.ServicioTuristicoes", "Servicio_ServicioHospedajeId", "dbo.ServicioHospedajes");
            DropForeignKey("dbo.ServicioTuristicoes", "Categoria_CategoriaHospedajeId", "dbo.CategoriaHospedajes");
            DropForeignKey("dbo.ServicioTuristicoes", "Calificacion_CalificacionHospedajeId", "dbo.CalificacionHospedajes");
            DropForeignKey("dbo.ServicioTuristicoes", "Categoria_CategoriaAlimentacionId", "dbo.CategoriaAlimentacions");
            DropIndex("dbo.ServicioTuristicoes", new[] { "Tipo_TipoTransporteId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Categoria_CategoriaTransporteId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Tipo_TipoHospedajeId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Servicio_ServicioHospedajeId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Categoria_CategoriaHospedajeId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Calificacion_CalificacionHospedajeId" });
            DropIndex("dbo.ServicioTuristicoes", new[] { "Categoria_CategoriaAlimentacionId" });
            DropTable("dbo.TipoComprobantes");
            DropTable("dbo.TipoTransportes");
            DropTable("dbo.MedioPagoes");
            DropTable("dbo.TipoHospedajes");
            DropTable("dbo.ServicioHospedajes");
            DropTable("dbo.Personas");
            DropTable("dbo.CategoriaTransportes");
            DropTable("dbo.CategoriaHospedajes");
            DropTable("dbo.CalificacionHospedajes");
            DropTable("dbo.CategoriaAlimentacions");
            DropTable("dbo.ServicioTuristicoes");
        }
    }
}
