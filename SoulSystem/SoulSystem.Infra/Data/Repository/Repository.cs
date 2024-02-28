using SoulSystem.Business.Core.Data;
using SoulSystem.Business.Core.Models;
using SoulSystem.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly SoulSystemContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(SoulSystemContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SalvarAlteracoes();
        }

        public virtual async Task SalvarAlteracoes(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SalvarAlteracoes();
        }

        public virtual async Task Excluir(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SalvarAlteracoes();
        }

        public async Task<int> SalvarAlteracoes()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
