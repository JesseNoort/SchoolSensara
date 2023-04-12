using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class LocationDTO :IDTO
{
    public string Name { get; set; }
    public int OrganisationId { get; set; }
}