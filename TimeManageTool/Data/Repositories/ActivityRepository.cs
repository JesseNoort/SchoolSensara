using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class ActivityRepository : EfCoreRepository<Activity, TimeManageContext>
{
    public ActivityRepository(TimeManageContext context) : base(context)
    {

    }
    
}