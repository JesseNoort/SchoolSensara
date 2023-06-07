using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Location :IEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int OrganisationId { get; set; }
    public Organisation Organisation { get; set; }

    public ICollection<Customer> Customers { get; set; }
}