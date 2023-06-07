using TimeManageTool.Data;
namespace TimeManageTool.DTOS;

public class CustomerDTO :IDTO
{   
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int phone { get; set; }
    public int LocationId { get; set; }
    
}