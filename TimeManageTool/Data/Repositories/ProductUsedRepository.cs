using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class ProductUsedRepository : EfCoreRepository<ProductUsed, TimeManageContext>
{
    public ProductUsedRepository(TimeManageContext context) : base(context)
    {

    }
    
}