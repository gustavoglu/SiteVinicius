using Site.Vinicius.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Site.Vinicius.Interfaces.AppService
{
    public interface IProdutoAppService : IDisposable
    {
        ProdutoViewModel Inserir(ProdutoViewModel produtoViewModel);

        ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel);

        ProdutoViewModel TrazerPorId(Guid Id);

        IEnumerable<ProdutoViewModel> TrazerTodosAtivos();

        IEnumerable<ProdutoViewModel> Pesquisar(Expression<Func<ProdutoViewModel, bool>> Predicate);
    }
}
