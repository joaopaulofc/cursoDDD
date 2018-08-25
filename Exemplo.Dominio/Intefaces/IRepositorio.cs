using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Exemplo.Dominio.Intefaces
{
    public interface IRepositorio<T> where T : IEntidade
    {
        IQueryable<T> Query(Expression<Func<T, bool>> predicado);
        IQueryable<T> Query(Expression<Func<T, bool>> predicado, params string[] includes);
        IQueryable<T> ObterTodos();
        T ObterPorId(Guid id);
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
    }
}
