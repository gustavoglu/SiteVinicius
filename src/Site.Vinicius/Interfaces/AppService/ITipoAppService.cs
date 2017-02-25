using Site.Vinicius.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Site.Vinicius.Interfaces.AppService
{
    public interface ITipoAppService : IDisposable
    {
        TipoViewModel Inserir(TipoViewModel tipoViewModel);

        TipoViewModel Atualizar(TipoViewModel tipoViewModel);

        TipoViewModel TrazerPorId(Guid Id);

        IEnumerable<TipoViewModel> TrazerTodosAtivos();

        IEnumerable<TipoViewModel> Pesquisar(Expression<Func<TipoViewModel, bool>> Predicate);
    }
}
