using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Activity :IEntity
{
    public int Id { get; set; }
    public List<Time>? Times { get; set; }
    public List<ProductUsed>? Products { get; set; }
    public DateTime DateTime { get; set; }
    public Customer Customer { get; set; }
    public double totalTimeSpend { get; set; }
    public User User { get; set; }
    
}