using Site.Vinicius.Data;
using Site.Vinicius.Models.Interfaces;

namespace Site.Vinicius.Models.Repository
{
    public class TipoRepository : Repository<Tipo>, ITipoRepository
    {
        public TipoRepository(ApplicationDbContext Db) : base(Db)
        {
        }
    }
}
