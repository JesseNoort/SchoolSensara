using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Time :IEntity
{
    public int Id { get; set; }
    public DateTime? TimeStart { get; set; }
    public DateTime? TimeEnd { get; set;}
    // {
    //     get
    //     {
    //         return this.TimeEnd;
    //     }
    //     set
    //     {
    //         var result = (this.TimeEnd - this.TimeStart);
    //         this.timeSpend = result.GetValueOrDefault().TotalMinutes;
    //     } 
    // }
    public String Description { get; set; }
    public double? timeSpend { get; set; }
    
    
}