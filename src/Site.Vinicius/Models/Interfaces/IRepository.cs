using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Site.Vinicius.Models.Interfaces
{
    public interface IRepository<T> : IDisposable where T : EntityBase
    {
        T Inserir(T obj);

        T Atualizar(T Obj);

        T TrazerPorId(Guid Id);

        IEnumerable<T> TrazerTodos();

        IEnumerable<T> TrazerTodosAtivos();

        IEnumerable<T> TrazerTodosDesativados();

        IEnumerable<T> Pesquisar(Expression<Func<T,bool>> Predicate);

        IEnumerable<T> TrazerTodosDeletados();

        int SaveChanges();

    }
}
