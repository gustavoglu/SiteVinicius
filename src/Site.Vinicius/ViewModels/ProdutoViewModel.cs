using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Guid Id_Tipo { get; set; }

        public virtual TipoViewModel Tipo { get; set; }

    }
}
