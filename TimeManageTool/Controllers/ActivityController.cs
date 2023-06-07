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
    public class ActivityController : BaseController<Activity, ActivityRepository, ActivityDTO>
    {
        
        public ActivityController(ActivityRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
        
        [HttpGet("byuser/{id}")]
        public async Task<ActionResult<IEnumerable<Activity>>> GetAllFromUser(int id)
        {
            var activities = await repository.GetAll();
            List<Activity> activitiesToAdd = new List<Activity>();
            foreach (var activity in activities)
            {
                if (activity.UserId == id)
                {
                    activitiesToAdd.Add(activity);
                }
            }

            return activitiesToAdd;
        }
        
        [HttpGet("byuser/closest/{id}")]
        public async Task<ActionResult<Activity>> GetClosestActivity(int id)
        {
            var activities = await repository.GetAll();
            List<Activity> activitiesToAdd = new List<Activity>();
            foreach (var activity in activities)
            {
                if (activity.UserId == id)
                {
                    activitiesToAdd.Add(activity);
                }
            }
            var toAdd = activitiesToAdd
                .Where(i => (i.Times == null || i.Times.FirstOrDefault()?.TimeEnd == null))
                .OrderBy(i => i.DateTime)
                .First();
            return toAdd;
        }
        
    }
}
