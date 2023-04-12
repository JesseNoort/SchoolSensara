using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Customer :IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int phone { get; set; }
    public Location Location { get; set; }
    public List<Activity>? Activities { get; set; }
    
}