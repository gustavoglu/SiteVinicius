using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.Models
{
    public class Produto : EntityBase
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Guid Id_Tipo { get; set; }

        public virtual Tipo Tipo { get; set; }


    }
}
