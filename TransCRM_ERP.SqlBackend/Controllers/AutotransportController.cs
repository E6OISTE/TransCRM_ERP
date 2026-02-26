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
    public class AutotransportController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AutotransportController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AutotransportGetAll()
        {
            var auto = await _context.Autotransports.ToListAsync();

            if (auto is null)
                return NotFound();

            return Ok(_mapper.Map<List<AutotransportReadBaseDto>>(auto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AutotransportGetById(Guid id)
        {
            var auto = await _context.Autotransports.FirstOrDefaultAsync(a => a.Id == id);

            if (auto is null)
                return NotFound();

            return Ok(_mapper.Map<AutotransportReadFullDto>(auto));
        }

        [HttpPost]
        public async Task<IActionResult> AutotransportPost([FromBody] AutotransportCreateDto auto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newAuto = _mapper.Map<Autotransport>(auto);

            await _context.Autotransports.AddAsync(newAuto);
            await _context.SaveChangesAsync();

            var resultDto = _mapper.Map<AutotransportReadFullDto>(newAuto);

            return CreatedAtAction(nameof(AutotransportGetById), new { id = newAuto.Id }, resultDto);
        }
    }
}