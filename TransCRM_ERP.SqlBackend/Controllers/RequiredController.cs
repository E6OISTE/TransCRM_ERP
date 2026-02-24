using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.DTO;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Infrastructure;

namespace TransCRM_ERP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequiredController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public RequiredController(AppDbContext context, IMapper mapper) : base()
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> RequiredGetFull()
        {
            var req = await _context.Requireds.ToListAsync();

            if (req is null)
                return NotFound();

            return Ok(_mapper.Map<RequiredReadFullDto>(req));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> RequiredGetById(Guid id)
        {
            var req = await _context.Requireds.FirstOrDefaultAsync(r => r.Id == id);

            if (req is null)
                return NotFound();

            return Ok(_mapper.Map<List<RequiredReadFullDto>>(req));
        }

        [HttpPost]
        public async Task<IActionResult> RequiredPost([FromBody] RequiredCreateDto auto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newRequired = _mapper.Map<Required>(auto);

            await _context.Requireds.AddAsync(newRequired);
            await _context.SaveChangesAsync();

            var resultDto = _mapper.Map<RequiredReadFullDto>(newRequired);

            return CreatedAtAction(nameof(RequiredGetById), new { id = newRequired.Id }, resultDto);
        }
    }
}
