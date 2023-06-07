using TimeManageTool.Data;
using TimeManageTool.Models;

namespace TimeManageTool.DTOS;

public class ActivityDTO : IDTO
{
    public int? Id { get; set; }
    public int UserId { get; set; }
    public int CustomerId { get; set; }
    public DateTime DateTime { get; set; }
}