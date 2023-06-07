using AutoMapper;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Profiles;

public class UserProfile: BaseProfile<User, UserDTO>
{
    public UserProfile()
    {
    }
}