using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class LocationRepository : EfCoreRepository<Location, TimeManageContext>
{
    public LocationRepository(TimeManageContext context) : base(context)
    {

    }

    // public async Task<IEnumerable<Location>> GetAllWithIncludes()
    // {
    //     return await context.Set<Location>().Include(l => l.Organisation).ToListAsync();
    // }
    
    
}