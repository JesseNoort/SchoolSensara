using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class TimeRepository : EfCoreRepository<Time, TimeManageContext>
{
    public TimeRepository(TimeManageContext context) : base(context)
    {

    }
    
}