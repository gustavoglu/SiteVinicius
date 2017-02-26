using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;
using AutoMapper;
using Site.Vinicius.Models;
using Site.Vinicius.Models.Interfaces;
using Site.Vinicius.Models.Repository;

namespace Site.Vinicius.Services.AppService
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaAppService(CategoriaRepository categoriaRepository)
        {
            this._categoriaRepository = categoriaRepository;
        }

        public CategoriaViewModel Atualizar(CategoriaViewModel categoriaViewModel)
        {
            var categoria = Mapper.Map<Categoria>(categoriaViewModel);
            return Mapper.Map<CategoriaViewModel>(_categoriaRepository.Atualizar(categoria));
        }

        public void Dispose()
        {
            this._categoriaRepository.Dispose();
        }

        public CategoriaViewModel Inserir(CategoriaViewModel categoriaViewModel)
        {
            var categoria = Mapper.Map<Categoria>(categoriaViewModel);
            return Mapper.Map<CategoriaViewModel>(_categoriaRepository.Inserir(categoria));

        }

        public IEnumerable<CategoriaViewModel> Pesquisar(Expression<Func<CategoriaViewModel, bool>> Predicate)
        {
            var pesquisa = _categoriaRepository.Pesquisar(Mapper.Map<Expression<Func<Categoria, bool>>>(Predicate));
            return Mapper.Map<IEnumerable<CategoriaViewModel>>(pesquisa);

        }

        public CategoriaViewModel TrazerPorId(Guid Id)
        {
            return Mapper.Map<CategoriaViewModel>(_categoriaRepository.TrazerPorId(Id));
        }

        public IEnumerable<CategoriaViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<CategoriaViewModel>>(_categoriaRepository.TrazerTodosAtivos());
        }
    }
}
