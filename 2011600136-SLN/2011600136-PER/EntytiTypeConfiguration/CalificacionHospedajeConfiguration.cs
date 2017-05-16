using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 2011600136-ENT.Entities;

namespace _2011600136_PER.EntytiTypeConfiguration
{
    class CalificacionHospedajeConfiguration : EntityTypeConfiguration<CalificacionHospedaje>
    {
        public CalificacionHospedajeConfiguration()
        {
            //Table Configurations

            ToTable("CalificacionesHospedajes");

            // creacion primary key

            HasKey(a => a.CalificacionHospedajeId);
        }
    }
}
