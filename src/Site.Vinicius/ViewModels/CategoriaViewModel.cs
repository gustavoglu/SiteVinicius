using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.ViewModels
{
    public class CategoriaViewModel
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<TipoViewModel> Tipos { get; set; }
    }
}
