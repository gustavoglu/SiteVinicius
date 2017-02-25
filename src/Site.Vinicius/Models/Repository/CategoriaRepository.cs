using Site.Vinicius.Data;
using Site.Vinicius.Models.Interfaces;

namespace Site.Vinicius.Models.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext Db) : base(Db)
        {
        }
    }
}
