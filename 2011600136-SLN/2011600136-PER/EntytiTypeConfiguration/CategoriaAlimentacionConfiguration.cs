using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 2011600136-ENT;

namespace _2011600136_PER.EntytiTypeConfiguration
{
    class CategoriaAlimentacionConfiguration : EntityTypeConfiguration<CategoriaAlimentacion>
    {
        public CategoriaAlimentacionConfiguration()
        {
            //Table Configurations

            ToTable("CategoriasAlimentaciones");

            // creacion primary key

            HasKey(a => a.CategoriaAlimentacionId);
        }
    }
}
