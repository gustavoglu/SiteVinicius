using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.Models
{
    public class Categoria : EntityBase
    {
        public string Descricao { get; set; }

        public ICollection<Tipo> Tipos { get; set; }
    }
}
