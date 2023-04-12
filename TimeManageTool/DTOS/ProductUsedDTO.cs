using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class ProductUsedDTO :IDTO
{
    public int ProductId { get; set; }
    public int Amount { get; set; }
}