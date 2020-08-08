using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaDomain
{
    public class Servico
    {
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public string Franquia { get; set; }
        public int Minutos { get; set; }
        public string OutrasOperadoras { get; set; }
        public double Preco { get; set; }
        public int PlanoId { get; set; }
        public virtual Plano NomePlano { get; set; }

        //public override string ToString()
        //{
        //    return this.NomeServico;
        //}
    }
}
