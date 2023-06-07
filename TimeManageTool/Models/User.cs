using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class User :IEntity
{
    [Key]
    public int Id { get; set; }
    public string name { get; set; }
    [JsonIgnore]
    public ICollection<Activity> Activities { get; set; }

}