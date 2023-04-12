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
    public class CustomerController : BaseController<Customer, CustomerRepository, CustomerDTO>
    {
        
        public CustomerController(CustomerRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
        
    }
}