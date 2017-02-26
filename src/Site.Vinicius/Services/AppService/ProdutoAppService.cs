using Site.Vinicius.Interfaces.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Vinicius.ViewModels;
using System.Linq.Expressions;
using Site.Vinicius.Models.Interfaces;
using Site.Vinicius.Models.Repository;
using AutoMapper;
using Site.Vinicius.Models;

namespace Site.Vinicius.Services.AppService
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(ProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }

        public ProdutoViewModel Atualizar(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<Produto>(produtoViewModel);
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.Atualizar(produto));
        }

        public void Dispose()
        {
            this._produtoRepository.Dispose();
        }

        public ProdutoViewModel Inserir(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<Produto>(produtoViewModel);
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.Inserir(produto));
        }

        public IEnumerable<ProdutoViewModel> Pesquisar(Expression<Func<ProdutoViewModel, bool>> Predicate)
        {
            var pesquisa = Mapper.Map<Expression<Func<Categoria, bool>>>(Predicate);
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(pesquisa);
        }

        public ProdutoViewModel TrazerPorId(Guid Id)
        {
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.TrazerPorId(Id));
        }

        public IEnumerable<ProdutoViewModel> TrazerTodosAtivos()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.TrazerTodosAtivos());
        }
    }
}
