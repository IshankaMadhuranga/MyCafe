using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Models;
using MyCafe.Services.Cafes;
using MyCafe.Services.Models;

namespace MyCafe.API.Controllers
{
    [Route("api/cafes")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        private readonly ICafeRepository _service;
        private readonly IMapper _mapper;

        public CafesController(ICafeRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetCafe")]
        public async Task<ActionResult<CafeFrom>> GetCafe(int id)
        {
            var cafe = await _service.GetCafe(id);

            if (cafe is null)
            {
                return NotFound();
            }

            var mappedCafe = _mapper.Map<CafeFrom>(cafe);

            return Ok(mappedCafe);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<CafeFrom>>> GetCafes([FromQuery] string? location)
        {
            var cafes = await _service.AllCafes();
            var mappedCafes = _mapper.Map<ICollection<CafeFrom>>(cafes);

            if (string.IsNullOrWhiteSpace(location))
            {
                return Ok(mappedCafes);
            }
            mappedCafes = mappedCafes.Where(t => t.Location == location).ToList();
            if (mappedCafes.Count == 0)
            {
                return NotFound();  //To do
            }
            return Ok(mappedCafes);
        }

        [HttpPost]
        public async Task<ActionResult<CafeFrom>> CreateCafe(CafeTo cafe)
        {
            var cafeEntity = _mapper.Map<Cafe>(cafe);
            var newCafe = await _service.AddCafe(cafeEntity);

            var newCafeForReturn = _mapper.Map<CafeFrom>(newCafe);

            return CreatedAtRoute("GetCafe", new { id = newCafeForReturn.Id }, newCafeForReturn);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCafe(int id, CafeTo cafe)
        {
            var updatingEntity = await _service.GetCafe(id);

            if (updatingEntity is null)
            {
                return NotFound();
            }
            _mapper.Map(cafe, updatingEntity);
            await _service.updateCafe(updatingEntity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCafe(int id)
        {
            var deleteEntity = await _service.GetCafe(id);

            if (deleteEntity is null)
            {
                return NotFound();
            }
            await _service.DeleteCafe(deleteEntity);
            return NoContent();
        }
      
    }
}
