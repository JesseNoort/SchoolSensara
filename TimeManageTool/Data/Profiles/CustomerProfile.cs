using AutoMapper;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Profiles;

public class CustomerProfile: BaseProfile<Customer, CustomerDTO>
{
    public CustomerProfile()
    {
    }
}