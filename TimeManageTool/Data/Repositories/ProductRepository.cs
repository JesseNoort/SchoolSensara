using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class ProductRepository : EfCoreRepository<Product, TimeManageContext>
{
    public ProductRepository(TimeManageContext context) : base(context)
    {

    }
    
}