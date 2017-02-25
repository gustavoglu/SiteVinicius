using Site.Vinicius.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Site.Vinicius.Interfaces.AppService
{
    public interface ICategoriaAppService : IDisposable
    {
        CategoriaViewModel Inserir(CategoriaViewModel categoriaViewModel);

        CategoriaViewModel Atualizar(CategoriaViewModel categoriaViewModel);

        CategoriaViewModel TrazerPorId(Guid Id);

        IEnumerable<CategoriaViewModel> TrazerTodosAtivos();

        IEnumerable<CategoriaViewModel> Pesquisar(Expression<Func<CategoriaViewModel, bool>> Predicate);
    }
}
