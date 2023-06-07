using System.ComponentModel.DataAnnotations;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class ProductUsed :IEntity
{
    [Key]
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Amount { get; set; }
    
    public int ActivityId { get; set; }
    public Activity Activity { get; set; }
}