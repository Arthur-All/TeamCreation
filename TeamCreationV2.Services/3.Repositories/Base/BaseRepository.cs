using Microsoft.EntityFrameworkCore;
using TeamCreationV2.Domain.Entites.Base;
using TeamCreationV2.Infra.Data;
using TeamCreationV2.Infra.Interfaces;

namespace TeamCreationV2.Services._1.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntite
    {
        public readonly AppDbContext _context;
        public readonly DbSet<T> _dbset;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }
        public async Task<T> GetById(int id)
        {
            return _dbset.Find(id);
        }
        public async Task<int> Add(T entite)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Add(entite);
                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return entite.Id;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
        public async Task<int> Remove(T entite)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Remove(entite);
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}