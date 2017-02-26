using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;
using Site.Vinicius.Models.Repository;
using Site.Vinicius.Models.Interfaces;
using AutoMapper;
using Site.Vinicius.Models;

namespace Site.Vinicius.Services.AppService
{
    public class TipoAppService : ITipoAppService
    {
        private ITipoRepository _tipoRepository;

        public TipoAppService(TipoRepository tipoRepository)
        {
            this._tipoRepository = tipoRepository;
        }

        public TipoViewModel Atualizar(TipoViewModel tipoViewModel)
        {
            var tipo = _tipoRepository.Atualizar(Mapper.Map<Tipo>(tipoViewModel));
            return Mapper.Map<TipoViewModel>(tipo);

        }

        public void Dispose()
        {
            _tipoRepository.Dispose();
        }

        public TipoViewModel Inserir(TipoViewModel tipoViewModel)
        {
            var tipo = _tipoRepository.Inserir(Mapper.Map<Tipo>(tipoViewModel));
            return Mapper.Map<TipoViewModel>(tipo);
        }

        public IEnumerable<TipoViewModel> Pesquisar(Expression<Func<TipoViewModel, bool>> Predicate)
        {
            var pesquisa = _tipoRepository.Pesquisar(Mapper.Map<Expression<Func<Tipo, bool>>>(Predicate));
            return Mapper.Map<IEnumerable<TipoViewModel>>(pesquisa);
        }

        public TipoViewModel TrazerPorId(Guid Id)
        {
            var tipo = _tipoRepository.TrazerPorId(Id);
            return Mapper.Map<TipoViewModel>(tipo);
        }

        public IEnumerable<TipoViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<TipoViewModel>>(_tipoRepository.TrazerTodosAtivos());
        }
    }
}
