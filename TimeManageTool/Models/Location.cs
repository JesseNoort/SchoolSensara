using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Location :IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Organisation Organisation { get; set; }
}