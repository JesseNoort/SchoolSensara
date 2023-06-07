using AutoMapper;
using TimeManageTool.Data;
using TimeManageTool.Data.Repositories;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Profiles;

public class LocationProfile: BaseProfile<Location,LocationDTO>
{
    public LocationProfile()
    {
        
    }
}