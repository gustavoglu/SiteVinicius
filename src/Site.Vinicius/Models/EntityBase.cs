using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Vinicius.Models
{
    public class EntityBase
    {
        public Guid Id { get; set; }

        public bool Ativo { get; set; }

        public bool Deletado { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime DeletadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }

        public string CriadoPor { get; set; }

        public string DeletadoPor { get; set; }

        public string AtualizadoPor { get; set; }

        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }

    }

}
