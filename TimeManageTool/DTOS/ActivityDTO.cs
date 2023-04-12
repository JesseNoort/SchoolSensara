using TimeManageTool.Data;
using TimeManageTool.Models;

namespace TimeManageTool.DTOS;

public class ActivityDTO : IDTO
{
    public int UserId { get; set; }
    public int CustomerId { get; set; }
    public List<int>? ProductId { get; set; }
    public List<int>? TimeId { get; set; }
}