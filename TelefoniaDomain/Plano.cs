using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoniaDomain
{
   public class Plano
    {
        public int Id { get; set; }
        public string NomePlano { get; set; }
        public int OperadoraId { get; set; }
        public virtual Operadora NomeOperadora { get; set; }

        //public override string ToString()
        //{
        //    return this.NomePlano;
        //}
    }
}
