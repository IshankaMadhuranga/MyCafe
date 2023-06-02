using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Services.Cafes;
using MyCafe.Services.Models;

namespace MyCafe.API.Controllers
{
    [Route("api/cafes")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        private readonly ICafeRepository _cafeService;
        private readonly IMapper _mapper;

        public CafesController(ICafeRepository service, IMapper mapper)
        {
            _cafeService = service;
            _mapper = mapper;
        }

        [HttpGet("{location?}")]
        public ActionResult<ICollection<CafeDto>> GetEmployees(string? location)
        {
            var cafes = _cafeService.AllCafes();
            var mappedCafes = _mapper.Map<ICollection<CafeDto>>(cafes);

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

        //[HttpPost]
        //public ActionResult<CafeDto> CreateAuthor(CreateCafeDto cafe)
        //{
        //    var cafeEntity = _mapper.Map<Author>(cafe);
        //    var newCafe = _service.AddCafe(cafeEntity);

        //    var cafeForReturn = _mapper.Map<CafeDto>(newCafe);

        //    return CreatedAtRoute("GetAuthor", new { id = cafeForReturn.Id },
        //        cafeForReturn);
        //}

        //[HttpDelete("{cafeId}")]
        //public ActionResult DeleteCafe(int cafeId)
        //{

        //}
    }
}
