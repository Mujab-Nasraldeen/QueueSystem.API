using Microsoft.EntityFrameworkCore;
using QueueSystem.API.Models;
using System.Linq.Expressions;

namespace QueueSystem.API.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsNoTracking();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await DbSet.Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression).AsQueryable();
            //return DbSet.Where(expression);
        }

        public IQueryable<T> Include(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeExpressions)
        {
            DbSet<T> dbSet = DbSet;

            includeExpressions.ToList().ForEach(x => DbSet.Include(x).Load());
            return DbSet;
        }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await DbSet.AddRangeAsync(entities);
        }

        public void UpdateAsync(T entity)
        {
            DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}
