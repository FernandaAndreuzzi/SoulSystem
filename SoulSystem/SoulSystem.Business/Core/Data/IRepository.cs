﻿using SoulSystem.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Core.Data
{
    public interface IRepository<TEntity>: IDisposable where TEntity : Entity
    {
        Task Adicionar (TEntity entity);
        Task<TEntity> ObterPorId (Guid id);
        Task<List<TEntity>> ObterTodos();
        Task SalvarAlteracoes(TEntity entity);
        Task Excluir (Guid Id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

    }
}
