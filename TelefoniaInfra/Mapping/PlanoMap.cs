using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using TelefoniaDomain;

namespace TelefoniaInfra.Mapping
{
   public class PlanoMap: EntityTypeConfiguration<Plano>
    {
        public PlanoMap()
        {
            ToTable("Plano");
            Property(x => x.OperadoraId);
            HasKey(x => x.Id);
            Property(x => x.NomePlano).HasMaxLength(30).IsRequired();
          

        }
    }
}
