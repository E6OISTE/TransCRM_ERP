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
    public class PassportController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public PassportController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> PassportsFullGet()
        {
            var passwd = await _context.Passports.ToListAsync();

            if (passwd is null)
                return NotFound();

            return Ok(_mapper.Map<List<PassportReadFullDto>>(passwd));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PassportsGetById(Guid id)
        {
            var password = await _context.Passports.FirstOrDefaultAsync(p => p.Id == id);

            if (password is null)
                return NotFound();

            return Ok(_mapper.Map<PassportReadFullDto>(password));
        }

        [HttpPost]
        public async Task<IActionResult> PassportPost([FromBody] PassportCreateDto passport)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newPassport = _mapper.Map<Passport>(passport);

            await _context.Passports.AddAsync(newPassport);
            await _context.SaveChangesAsync();

            var resultDto = _mapper.Map<PassportReadFullDto>(passport);

            return CreatedAtAction(nameof(PassportsGetById), new { id = newPassport.Id }, resultDto);
        }
    }
}