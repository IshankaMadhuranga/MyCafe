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

        public CafesController(ICafeRepository service)
        {
            _cafeService = service;
        }

        [HttpGet("{location?}")]
        public ActionResult<ICollection<CafeDto>> GetEmployees(string? location)
        {
            var cafes = _cafeService.AllCafes();
            var cafesDto = new List<CafeDto>();
            foreach (var cafe in cafes)
            {
                cafesDto.Add(new CafeDto
                {
                    Id = cafe.Id,
                    Name = cafe.Name,
                    Description = cafe.Description,
                    Location = cafe.Location,
                    TotalEmployees = cafe.Employees.Count,

                });
            }

            if (location == null)
            {
                return Ok(cafesDto);
            }
            cafesDto = cafesDto.Where(t => t.Location == location).ToList();
            if (cafesDto.Count == 0)
            {
                return NotFound();  //To do
            }
            return Ok(cafesDto);
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
