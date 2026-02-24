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
    public class DriverLicenseController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DriverLicenseController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> DriverLicenseGetFull()
        {
            var licenses = await _context.DriverLicenses.ToListAsync();

            if (licenses == null)
                return NotFound();

            return Ok(_mapper.Map<List<DriverLicenseReadFullDto>>(licenses));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DriverLicenseGetById(Guid id)
        {
            var licenses = await _context.DriverLicenses.FirstOrDefaultAsync(licId => licId.Id == id);

            if (licenses == null)
                return NotFound();

            return Ok(_mapper.Map<DriverLicenseReadFullDto>(licenses));
        }

        [HttpPost]
        public async Task<IActionResult> DriverLicensePost([FromBody] DriverLicenseCreateDto driverLicense)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var license = _mapper.Map<DriverLicense>(driverLicense);
            await _context.DriverLicenses.AddAsync(license);
            await _context.SaveChangesAsync();

            var resultDto = _mapper.Map<DriverLicenseCreateDto>(license);

            return CreatedAtAction(nameof(DriverLicenseGetById), new { id = license.Id}, resultDto);
        }
    }
}
