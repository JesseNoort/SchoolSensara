using AutoMapper;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Profiles;

public class TimeProfile: BaseProfile<Time, TimeDTO>
{
    public TimeProfile()
    {
    }
}