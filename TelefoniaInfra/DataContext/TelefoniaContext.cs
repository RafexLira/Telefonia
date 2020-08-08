using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefoniaDomain;
using TelefoniaInfra.Mapping;

namespace TelefoniaInfra.DataContext
{
    public class TelefoniaContext: DbContext
    {
        public DbSet<Operadora> Operadoras { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Plano> Planos { get; set; }

        public TelefoniaContext() : base("DbTelefonia")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OperadoraMap());
            modelBuilder.Configurations.Add(new PlanoMap());
            modelBuilder.Configurations.Add(new ServicoMap());
            base.OnModelCreating(modelBuilder);
        }

        //public class TelefoniaContextInitialize : DropCreateDatabaseIfModelChanges<TelefoniaContext>
        //{
        //    protected override void Seed(TelefoniaContext context)
        //    {
        //        context.Operadoras.Add(new Operadora {Id =1, NomeOperadora="Claro", DDD="22" });
        //        context.Operadoras.Add(new Operadora {Id =2, NomeOperadora="Vivo", DDD="23" });
        //        context.Operadoras.Add(new Operadora {Id =3, NomeOperadora="TIM", DDD="24" });
        //        context.Operadoras.Add(new Operadora {Id =4, NomeOperadora="Oi", DDD="21" });
        //        context.Servicos.Add( new Servico { });
        //        context.Planos.Add(new Plano{ });

        //        context.SaveChanges();
        //        base.Seed(context);
        //    }
        //}


        //public class TelefoniaContextInitialize : DropCreateDatabaseIfModelChanges<TelefoniaContext>
        //{
        //    protected override void Seed(TelefoniaContext context)
        //    {
        //         
        //context.Operadoras.Add(new Operadora { Id = 2, NomeOperadora = "Claro", DDD = "22" });

        //    context.Planos.Add(new Plano { OperadoraId = 2, Id = 1, NomePlano = "Pós-pago" });

        //    context.Servicos.Add(new Servico { PlanoId = 1, Id = 1, NomeServico = "Claro Econômico", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB + WhatsApp e Facebook grátis", Preco = 39.90 });
        //    context.Servicos.Add(new Servico { PlanoId = 1, Id = 2, NomeServico = "Claro Familia", Minutos = 200, OutrasOperadoras = "Sim", Franquia = "30GB + WhatsApp e Facebook grátis", Preco = 129.90 });
        //    context.Servicos.Add(new Servico { PlanoId = 1, Id = 3, NomeServico = "Claro Empresarial", Minutos = 300, OutrasOperadoras = "Sim", Franquia = "50GB WhatsApp e Facebook grátis", Preco = 149.90 });
        //    context.Servicos.Add(new Servico { PlanoId = 1, Id = 4, NomeServico = "Claro Micro", Minutos = 250, OutrasOperadoras = "Sim", Franquia = "35GB WhatsApp e Facebook grátis", Preco = 109.90 });

        //    context.Planos.Add(new Plano { OperadoraId = 1, Id = 2, NomePlano = "Pré-pago" });

        //    context.Servicos.Add(new Servico { PlanoId = 2, Id = 1, NomeServico = "Claro Turbo", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "2GB por 2 Semanas", Preco = 35.00 });
        //    context.Servicos.Add(new Servico { PlanoId = 2, Id = 2, NomeServico = "Claro Sempre", Minutos = 40, OutrasOperadoras = "Sim", Franquia = "3GB por semana", Preco = 15.00 });
        //    context.Servicos.Add(new Servico { PlanoId = 2, Id = 3, NomeServico = "Claro Básico", Minutos = 12, OutrasOperadoras = "Não", Franquia = "1GB por semana", Preco = 10.00 });

        //    context.Planos.Add(new Plano { OperadoraId = 1, Id = 3, NomePlano = "Controle" });

        //    context.Servicos.Add(new Servico { PlanoId = 3, Id = 1, NomeServico = "Claro Controle", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB Mensais + WhatsApp", Preco = 29.90 });
        //    context.Servicos.Add(new Servico { PlanoId = 3, Id = 2, NomeServico = "Claro Controle Plus", Minutos = 60, OutrasOperadoras = "Sim", Franquia = "8GB Mensais + WhatsApp e Facebook grátis", Preco = 59.90 });

        //    context.SaveChanges();
        //           base.Seed(context);
        //    }
        //}

    }
}
