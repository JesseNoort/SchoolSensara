using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeManageTool.Data.Repositories;
using TimeManageTool.DTOS;
using TimeManageTool.Models;

namespace TimeManageTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class ProductUsedController : BaseController<ProductUsed, ProductUsedRepository, ProductUsedDTO>
    {
        
        public ProductUsedController(ProductUsedRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
        
    }
}