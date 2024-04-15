using Microsoft.EntityFrameworkCore;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Infrastructure.Data;

namespace RecipeBytes.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity>(RecipeBytesDbContext dbContext) : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly RecipeBytesDbContext _dbContext = dbContext;

        #region query
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }
        #endregion

        #region command

        public async Task AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTimeOffset.Now;
            entity.UpdatedDate = DateTimeOffset.Now;
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreatedDate = DateTimeOffset.Now;
                entity.UpdatedDate = DateTimeOffset.Now;
            }
            await _dbContext.Set<TEntity>().AddRangeAsync(entities);
            await SaveChangesAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await SaveChangesAsync();
        }

        public async Task RemoveAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await RemoveAsync(entity);
            await SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
            await SaveChangesAsync();
        }
        #endregion

        public async Task SaveChangesAsync()
        {
            AddAutoInfo();
            await _dbContext.SaveChangesAsync();
        }

        private void AddAutoInfo()
        {
            var changedEntities = _dbContext.ChangeTracker.Entries()
                .Where(E => E.State == EntityState.Modified)
                .ToList();
            foreach(var entity in changedEntities)
                entity.Property("UpdatedDate").CurrentValue = DateTimeOffset.Now;
        }
    }
}
