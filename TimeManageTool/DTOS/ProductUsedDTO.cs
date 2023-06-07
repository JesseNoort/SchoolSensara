using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class ProductUsedDTO :IDTO
{
    public int? Id { get; set; }
    public int ProductId { get; set; }
    public int ActivityId { get; set; }
    public int Amount { get; set; }
}