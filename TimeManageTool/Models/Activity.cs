using System.ComponentModel.DataAnnotations;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Activity :IEntity
{
    [Key]
    public int Id { get; set; }
    public ICollection<Time> Times { get; set; }
    public ICollection<ProductUsed> Products { get; set; }
    public DateTime DateTime { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public double totalTimeSpend { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    
}