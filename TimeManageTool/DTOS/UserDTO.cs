using TimeManageTool.Data;

namespace TimeManageTool.DTOS;

public class UserDTO :IDTO
{
    public int? Id { get; set; }
    public string name { get; set; }
}