using Site.Vinicius.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.ViewModels
{
    public class TipoViewModel
    {
        public string Descricao { get; set; }

        public Guid Id_Categoria { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }
    }
}
