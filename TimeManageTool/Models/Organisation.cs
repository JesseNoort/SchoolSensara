using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Organisation :IEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Location> Locations { get; set; }
}