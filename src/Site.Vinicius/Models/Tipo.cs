using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.Models
{
    public class Tipo : EntityBase
    {
        public string Descricao { get; set; }

        public Guid Id_Categoria { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
