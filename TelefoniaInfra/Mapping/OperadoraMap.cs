using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefoniaDomain;

namespace TelefoniaInfra.Mapping
{
   public class OperadoraMap : EntityTypeConfiguration<Operadora>
    {
        public OperadoraMap()
        {
            ToTable("Operadora");
            HasKey(x => x.Id);
            Property(x => x.NomeOperadora).HasMaxLength(10).IsRequired();
            Property(x => x.DDD).HasMaxLength(10).IsRequired();
        }
    }
}
