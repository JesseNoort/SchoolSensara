using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class LocationRepository : EfCoreRepository<Location, TimeManageContext>
{
    public LocationRepository(TimeManageContext context) : base(context)
    {

    }
    
}