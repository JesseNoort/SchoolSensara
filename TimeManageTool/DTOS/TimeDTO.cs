using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class TimeDTO : IDTO
{
    public int? id { get; set; }
    public DateTime? timeStart { get; set; }
    public DateTime? timeEnd { get; set; }
    public double? TimeSpend { get; set; }
    public int ActivityId { get; set; }
    public String? Description { get; set; }
}