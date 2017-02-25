using Site.Vinicius.Data;
using Site.Vinicius.Models.Interfaces;

namespace Site.Vinicius.Models.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext Db) : base(Db)
        {
        }
    }
}
