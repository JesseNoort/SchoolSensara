using System.ComponentModel.DataAnnotations;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Time :IEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime? TimeStart { get; set; }
    public DateTime? TimeEnd { get; set;}
    public String Description { get; set; }
    public double? timeSpend { get; set; }
    public int ActivityId { get; set; }
    public Activity Activity { get; set; }
    
    
}