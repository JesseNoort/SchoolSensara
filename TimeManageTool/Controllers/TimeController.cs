using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeManageTool.Data;
using TimeManageTool.Data.Repositories;
using TimeManageTool.DTOS;
using TimeManageTool.Models;
using static System.DateTime;

namespace TimeManageTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class TimeController : BaseController<Time, TimeRepository, TimeDTO>
    {

        public TimeController(TimeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpPut("timeSet/{id}")]
        public async Task<IActionResult> PutTime(int id, TimeDTO dto)
        {
            var entity = _mapper.Map<Time>(dto);
            if (id != entity.Id)
            {
                return BadRequest();
            }

            if (entity.timeSpend == null && (entity.TimeStart !=null && entity.TimeEnd !=null))
            {
                var ts = entity.TimeEnd - entity.TimeStart;
                entity.timeSpend = ts.Value.TotalMinutes;
            }
            await repository.Update(entity);
            return NoContent();
        }

        
    }
}