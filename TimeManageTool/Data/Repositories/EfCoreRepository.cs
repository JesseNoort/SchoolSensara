using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TimeManageTool.Data.EFCore;

public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class, IEntity
    where TContext : DbContext
{
    protected readonly TContext context;
    public EfCoreRepository(TContext context)
    {
        this.context = context;
    }
    public async Task<TEntity> Add(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> Delete(int id)
    {
        var entity = await context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return entity;
        }

        context.Set<TEntity>().Remove(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> Get(int id)
    {
        var entityType = typeof(TEntity);
        var navigationProperties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => (p.PropertyType.IsGenericType &&
                         (p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>) ||
                          p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>)) ||
                         p.PropertyType.GetInterfaces().Any(i => i.IsGenericType &&
                                                                 i.GetGenericTypeDefinition() == typeof(IEnumerable<>)) &&
                         p.PropertyType != typeof(string)) ||
                        context.Model.FindEntityType(p.PropertyType) != null);

        IQueryable<TEntity> query = context.Set<TEntity>();

        foreach (var navigationProperty in navigationProperties)
        {
            query = query.Include(navigationProperty.Name);
        }

        return await query.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<List<TEntity>> GetAll()
    {
        // return await context.Set<TEntity>().ToListAsync();
        var entityType = typeof(TEntity);
        var navigationProperties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.PropertyType.IsGenericType &&
                        (p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>) ||
                         p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>)) ||
                        p.PropertyType.GetInterfaces().Any(i => i.IsGenericType &&
                                                                i.GetGenericTypeDefinition() == typeof(IEnumerable<>)) &&
                        p.PropertyType != typeof(string) ||
                        context.Model.FindEntityType(p.PropertyType) != null);

        IQueryable<TEntity> query = context.Set<TEntity>();

        foreach (var navigationProperty in navigationProperties)
        {
            query = query.Include(navigationProperty.Name);
        }

        return await query.ToListAsync();
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return entity;
    }
    
}