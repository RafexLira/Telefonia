namespace TelefoniaInfra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TelefoniaDomain;

    internal sealed class Configuration : DbMigrationsConfiguration<TelefoniaInfra.DataContext.TelefoniaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TelefoniaInfra.DataContext.TelefoniaContext context)
        {          
            
            //context.Operadoras.Add(new Operadora { Id = 1, NomeOperadora = "Vivo", DDD = "21" });

            //context.Planos.Add(new Plano { OperadoraId = 1, Id = 1, NomePlano = "Pós-pago" });          

            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 1, NomeServico = "Vivo Econômico", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB + WhatsApp e Facebook grátis", Preco = 39.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 2, NomeServico = "Vivo Familia", Minutos = 200, OutrasOperadoras = "Sim", Franquia = "30GB + WhatsApp e Facebook grátis", Preco = 129.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 3, NomeServico = "Vivo Empresarial", Minutos = 300, OutrasOperadoras = "Sim", Franquia = "50GB WhatsApp e Facebook grátis", Preco = 149.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 4, NomeServico = "Vivo Micro", Minutos = 250, OutrasOperadoras = "Sim", Franquia = "35GB WhatsApp e Facebook grátis", Preco = 109.90 });

            //context.Planos.Add(new Plano { OperadoraId = 1, Id = 2, NomePlano = "Pré-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 1, NomeServico = "Vivo Turbo", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "2GB por 2 Semanas", Preco = 35.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 2, NomeServico = "Vivo Sempre", Minutos = 40, OutrasOperadoras = "Sim", Franquia = "3GB por semana", Preco = 15.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 3, NomeServico = "Vivo Básico", Minutos = 12, OutrasOperadoras = "Não", Franquia = "1GB por semana", Preco = 10.00 });

            //context.Planos.Add(new Plano { OperadoraId = 1, Id = 3, NomePlano = "Controle" });

            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 1, NomeServico = "Vivo Controle", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB Mensais + WhatsApp", Preco = 29.90 });
            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 2, NomeServico = "Vivo Controle Plus", Minutos = 60, OutrasOperadoras = "Sim", Franquia = "8GB Mensais + WhatsApp e Facebook grátis", Preco = 59.90 });

            //context.SaveChanges();
            ////____________________________________________//_____________________________________________

            //context.Operadoras.Add(new Operadora { Id = 2, NomeOperadora = "Claro", DDD = "22" });

            //context.Planos.Add(new Plano { OperadoraId = 2, Id = 1, NomePlano = "Pós-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 1, NomeServico = "Claro Econômico", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB + WhatsApp e Facebook grátis", Preco = 39.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 2, NomeServico = "Claro Familia", Minutos = 200, OutrasOperadoras = "Sim", Franquia = "30GB + WhatsApp e Facebook grátis", Preco = 129.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 3, NomeServico = "Claro Empresarial", Minutos = 300, OutrasOperadoras = "Sim", Franquia = "50GB WhatsApp e Facebook grátis", Preco = 149.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 4, NomeServico = "Claro Micro", Minutos = 250, OutrasOperadoras = "Sim", Franquia = "35GB WhatsApp e Facebook grátis", Preco = 109.90 });

            //context.Planos.Add(new Plano { OperadoraId = 2, Id = 2, NomePlano = "Pré-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 1, NomeServico = "Claro Turbo", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "2GB por 2 Semanas", Preco = 35.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 2, NomeServico = "Claro Sempre", Minutos = 40, OutrasOperadoras = "Sim", Franquia = "3GB por semana", Preco = 15.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 3, NomeServico = "Claro Básico", Minutos = 12, OutrasOperadoras = "Não", Franquia = "1GB por semana", Preco = 10.00 });

            //context.Planos.Add(new Plano { OperadoraId = 2, Id = 3, NomePlano = "Controle" });

            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 1, NomeServico = "Claro Controle", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB Mensais + WhatsApp", Preco = 29.90 });
            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 2, NomeServico = "Claro Controle Plus", Minutos = 60, OutrasOperadoras = "Sim", Franquia = "8GB Mensais + WhatsApp e Facebook grátis", Preco = 59.90 });

            //context.SaveChanges();
            ////____________________________________________//_____________________________________________

            //context.Operadoras.Add(new Operadora { Id = 3, NomeOperadora = "Oi", DDD = "23" });

            //context.Planos.Add(new Plano { OperadoraId = 3, Id = 1, NomePlano = "Pós-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 1, NomeServico = "Oi Econômico", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB + WhatsApp e Facebook grátis", Preco = 39.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 2, NomeServico = "Oi Familia", Minutos = 200, OutrasOperadoras = "Sim", Franquia = "30GB + WhatsApp e Facebook grátis", Preco = 129.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 3, NomeServico = "Oi Empresarial", Minutos = 300, OutrasOperadoras = "Sim", Franquia = "50GB WhatsApp e Facebook grátis", Preco = 149.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 4, NomeServico = "Oi Micro", Minutos = 250, OutrasOperadoras = "Sim", Franquia = "35GB WhatsApp e Facebook grátis", Preco = 109.90 });

            //context.Planos.Add(new Plano { OperadoraId = 3, Id = 2, NomePlano = "Pré-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 1, NomeServico = "Oi Turbo", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "2GB por 2 Semanas", Preco = 35.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 2, NomeServico = "Oi Sempre", Minutos = 40, OutrasOperadoras = "Sim", Franquia = "3GB por semana", Preco = 15.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 3, NomeServico = "Oi Básico", Minutos = 12, OutrasOperadoras = "Não", Franquia = "1GB por semana", Preco = 10.00 });

            //context.Planos.Add(new Plano { OperadoraId = 3, Id = 3, NomePlano = "Controle" });

            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 1, NomeServico = "Oi Controle", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB Mensais + WhatsApp", Preco = 29.90 });
            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 2, NomeServico = "Oi Controle Plus", Minutos = 60, OutrasOperadoras = "Sim", Franquia = "8GB Mensais + WhatsApp e Facebook grátis", Preco = 59.90 });

            //context.SaveChanges();
            ////____________________________________________//_____________________________________________

            //context.Operadoras.Add(new Operadora { Id = 4, NomeOperadora = "Tim", DDD = "22" });

            //context.Planos.Add(new Plano { OperadoraId = 4, Id = 1, NomePlano = "Pós-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 1, NomeServico = "Tim Econômico", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB + WhatsApp e Facebook grátis", Preco = 39.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 2, NomeServico = "Tim Familia", Minutos = 200, OutrasOperadoras = "Sim", Franquia = "30GB + WhatsApp e Facebook grátis", Preco = 129.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 3, NomeServico = "Tim Empresarial", Minutos = 300, OutrasOperadoras = "Sim", Franquia = "50GB WhatsApp e Facebook grátis", Preco = 149.90 });
            //context.Servicos.Add(new Servico { PlanoId = 1, Id = 4, NomeServico = "Tim Micro", Minutos = 250, OutrasOperadoras = "Sim", Franquia = "35GB WhatsApp e Facebook grátis", Preco = 109.90 });

            //context.Planos.Add(new Plano { OperadoraId = 4, Id = 2, NomePlano = "Pré-pago" });

            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 1, NomeServico = "Tim Turbo", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "2GB por 2 Semanas", Preco = 35.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 2, NomeServico = "Tim Sempre", Minutos = 40, OutrasOperadoras = "Sim", Franquia = "3GB por semana", Preco = 15.00 });
            //context.Servicos.Add(new Servico { PlanoId = 2, Id = 3, NomeServico = "Tim Básico", Minutos = 12, OutrasOperadoras = "Não", Franquia = "1GB por semana", Preco = 10.00 });

            //context.Planos.Add(new Plano { OperadoraId = 4, Id = 3, NomePlano = "Controle" });

            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 1, NomeServico = "Tim Controle", Minutos = 30, OutrasOperadoras = "Sim", Franquia = "4GB Mensais + WhatsApp", Preco = 29.90 });
            //context.Servicos.Add(new Servico { PlanoId = 3, Id = 2, NomeServico = "Tim Controle Plus", Minutos = 60, OutrasOperadoras = "Sim", Franquia = "8GB Mensais + WhatsApp e Facebook grátis", Preco = 59.90 });

            //context.SaveChanges();


        }
    }
}
