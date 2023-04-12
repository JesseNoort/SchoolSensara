using AutoMapper;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Data.Profiles;

public class ActivityProfile : Profile
{
    public ActivityProfile()
    {
        CreateMap<ActivityDTO, Activity>().ReverseMap();
        CreateMap<Activity,ActivityDTO>();
    }
}
            