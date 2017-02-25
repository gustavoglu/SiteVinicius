using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;

namespace Site.Vinicius.Services.AppService
{
    public class ProdutoAppService : IProdutoAppService
    {
        public ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProdutoViewModel Inserir(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoViewModel> Pesquisar(Expression<Func<ProdutoViewModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public ProdutoViewModel TrazerPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoViewModel> TrazerTodosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
