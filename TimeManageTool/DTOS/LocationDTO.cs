using TimeManageTool.Data;
using TimeManageTool.Models;

namespace TimeManageTool.DTOS;

public class LocationDTO :IDTO
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int OrganisationId { get; set; }
}