using Site.Vinicius.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Site.Vinicius.Data;
using Microsoft.EntityFrameworkCore;

namespace Site.Vinicius.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private ApplicationDbContext _Db;
        private DbSet<T> DbSet;

        public Repository(ApplicationDbContext Db)
        {
            _Db = Db;
            DbSet = _Db.Set<T>();
        }

        public virtual T Atualizar(T Obj)
        {
            var entry = _Db.Entry(Obj);

            entry.State = EntityState.Modified;

            DbSet.Add(Obj);

            return Obj;

        }

        public void Dispose()
        {
            _Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual  T Inserir(T obj)
        {
            DbSet.Add(obj);

            return obj;
        }

        public virtual IEnumerable<T> Pesquisar(Expression<Func<T, bool>> Predicate)
        {
           return DbSet.Where(Predicate);
        }

        public int SaveChanges()
        {
           return _Db.SaveChanges();
        }

        public virtual T TrazerPorId(Guid Id)
        {
            var objReturn = DbSet.SingleOrDefault(obj => obj.Id == Id);

            return objReturn;
        }

        public virtual IEnumerable<T> TrazerTodos()
        {
            return DbSet;
        }

        public virtual IEnumerable<T> TrazerTodosAtivos()
        {
            return DbSet.Where(obj => obj.Ativo == true);
        }

        public virtual IEnumerable<T> TrazerTodosDeletados()
        {
            return DbSet.Where(obj => obj.Deletado == true);
        }

        public virtual IEnumerable<T> TrazerTodosDesativados()
        {
            return DbSet.Where(obj => obj.Deletado == true);
        }
    }
}
