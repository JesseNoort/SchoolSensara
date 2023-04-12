using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class CustomerRepository : EfCoreRepository<Customer, TimeManageContext>
{
    public CustomerRepository(TimeManageContext context) : base(context)
    {

    }
    
}