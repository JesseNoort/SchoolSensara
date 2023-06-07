using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Customer :IEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int phone { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    [JsonIgnore]
    public ICollection<Activity>? Activities { get; set; }
    
}