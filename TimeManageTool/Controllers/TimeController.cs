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
        protected readonly IMapper _mapper;
        protected readonly TimeRepository _repository;

        public TimeController(TimeRepository repository, IMapper mapper) : base(repository, mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        
        [HttpPost("/addtime")]
        public async Task<ActionResult<Time>> Post(TimeDTO dto)
        {
            var entity = new Time();
            if (dto.timeStart != null)
            {
                entity.TimeStart = Now;
            }

            entity.Description = dto.Description;
            var get = nameof(Get);
            await _repository.Add(entity);
            return CreatedAtAction(get, new { id = entity.Id }, entity);
        }
        
        [HttpPut("addtime/{id}")]
        public async Task<IActionResult> Put(int id, TimeDTO entity)
        {
            var time =_mapper.Map<Time>(entity);
            var check = _repository.Get(id);
            if (check.Id == null)
            {
                return BadRequest();
            }

            if (entity.timeStart != null)
            {
                check.Result.TimeStart = entity.timeStart;
            }

            if (entity.timeEnd != null)
            {
                check.Result.TimeEnd = entity.timeEnd;
            }

            if (entity.Description != null)
            {
                check.Result.Description = entity.Description;
            }

            if (check.Result.TimeEnd != null && check.Result.TimeStart != null)
            {
                var timeSpend = (check.Result.TimeEnd - check.Result.TimeEnd);
                check.Result.timeSpend = timeSpend.GetValueOrDefault().TotalMinutes;
            }
            
            await _repository.Update(check.Result);
            return NoContent();
        }

        
    }
}