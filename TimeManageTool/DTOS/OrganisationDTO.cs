using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class OrganisationDTO :IDTO
{
    public int? Id { get; set; }
    public string Name { get; set; }
}