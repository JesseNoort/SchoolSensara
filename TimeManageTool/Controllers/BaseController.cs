using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TimeManageTool.Data;
using TimeManageTool.Models;

namespace TimeManageTool.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository,TDTO> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
        where  TDTO: class,IDTO
    {
        protected readonly TRepository repository;
        protected readonly IMapper _mapper;

        public BaseController(TRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.Update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var get = nameof(Get);
            await repository.Add(entity);
            return CreatedAtAction(get, new { id = entity.Id }, entity);
        }
        
        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

    }