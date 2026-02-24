using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.DTO;
using TransCRM_ERP.Infrastructure;

namespace TransCRM_ERP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DriverController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task<IActionResult> DriverGetBase()
        //{
        //    var driver = await _context.Drivers.FirstOrDefaultAsync();

        //    if (driver == null)
        //        return NotFound();

        //    return Ok(_mapper.Map<List<DriverReadBaseDto>>(driver));
        //}

        [HttpGet]
        public async Task<IActionResult> DriverGetFull()
        {
            var driver = await _context.Drivers.ToListAsync();

            if (driver == null)
                return NotFound();

            return Ok(_mapper.Map<List<DriverReadFullDto>>(driver));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DriverGetById(Guid id)
        {
            var driver = await _context.Drivers.FirstOrDefaultAsync(dr => dr.Id == id);

            if (driver == null)
                return NotFound();

            return Ok(_mapper.Map<DriverReadFullDto>(driver));
        }

        [HttpPost]
        public async Task<IActionResult> DriverPost([FromBody] DriverCreateDto driver)
        {

            return Ok();
        }
    }
}
