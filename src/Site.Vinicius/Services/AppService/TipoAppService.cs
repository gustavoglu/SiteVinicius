using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;
using Site.Vinicius.Models.Repository;
using Site.Vinicius.Models.Interfaces;

namespace Site.Vinicius.Services.AppService
{
    public class TipoAppService : ITipoAppService
    {
        private TipoRepository _tipoRepository;

        public TipoAppService(ITipoRepository tipoRepository)
        {
        //    this._tipoRepository = tipoRepository;
        }

        public TipoViewModel Atualizar(TipoViewModel tipoViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TipoViewModel Inserir(TipoViewModel tipoViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoViewModel> Pesquisar(Expression<Func<TipoViewModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public TipoViewModel TrazerPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoViewModel> TrazerTodosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
