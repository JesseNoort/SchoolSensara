using AutoMapper;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Profiles;

public class ProductProfile: BaseProfile<Product, ProductDTO>
{
    public ProductProfile()
    {
    }
}