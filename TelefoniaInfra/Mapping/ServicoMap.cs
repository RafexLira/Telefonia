using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefoniaDomain;

namespace TelefoniaInfra.Mapping
{
   public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            ToTable("Servico");
            Property(x => x.PlanoId);
            HasKey(x => x.Id);
            Property(x => x.NomeServico).HasMaxLength(60).IsRequired();            
            Property(x => x.Franquia).HasMaxLength(60).IsRequired();
            Property(x => x.Minutos).IsRequired();
            Property(x => x.OutrasOperadoras).HasMaxLength(10).IsRequired();
            Property(x => x.Preco);
        }
    }
}
