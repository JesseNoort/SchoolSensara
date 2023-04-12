using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class User :IEntity
{
    public int Id { get; set; }
    public string name { get; set; }
    public List<Activity>? Activities { get; set; }

}