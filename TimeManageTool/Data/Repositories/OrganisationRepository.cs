using TimeManageTool.Data.EFCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Repositories;

public class OrganisationRepository : EfCoreRepository<Organisation, TimeManageContext>
{
    public OrganisationRepository(TimeManageContext context) : base(context)
    {

    }
    
}