using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class UserRepository : EfCoreRepository<User, TimeManageContext>
{
    public UserRepository(TimeManageContext context) : base(context)
    {

    }
    
}