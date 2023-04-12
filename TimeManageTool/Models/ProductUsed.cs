using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class ProductUsed :IEntity
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Amount { get; set; }
}