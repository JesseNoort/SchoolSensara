using System.ComponentModel.DataAnnotations;
using TimeManageTool.Data;

namespace TimeManageTool.Models;

public class Product :IEntity
{    
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductUsed>  Products {get; set; }

}