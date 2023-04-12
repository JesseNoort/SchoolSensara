using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Organisation :IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}