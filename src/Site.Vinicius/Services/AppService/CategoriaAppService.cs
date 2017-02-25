using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;

namespace Site.Vinicius.Services.AppService
{
    public class CategoriaAppService : ICategoriaAppService
    {
        public CategoriaViewModel Atualizar(CategoriaViewModel categoriaViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CategoriaViewModel Inserir(CategoriaViewModel categoriaViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaViewModel> Pesquisar(Expression<Func<CategoriaViewModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public CategoriaViewModel TrazerPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaViewModel> TrazerTodosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
