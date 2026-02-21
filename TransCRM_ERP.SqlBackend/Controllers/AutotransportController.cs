using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Collections.Generic;
using TransCRM_ERP.DTO;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Infrastructure;
using System.Threading.Tasks;

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

            if (auto == null)
                return NotFound();

            return Ok(_mapper.Map<List<AutotransportReadBaseDto>>(auto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AutotransportGetById(Guid id)
        {
            var auto = await _context.Autotransports.FirstOrDefaultAsync(a => a.Id == id);

            if (auto == null)
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

    //[ApiController]
    //[Route("/api/[controller]")]
    //public class AutotransportController : ControllerBase
    //{
    //    private readonly AppDbContext _appDbContext;
    //    private readonly IMapper _mapper;

    //    public AutotransportController(AppDbContext appDbContext /*IMapper mapper*/)
    //    {
    //        _appDbContext = appDbContext;
    //        //_mapper = mapper;
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<Autotransport>> AutotransportCreate(AutotransportReadFullDto dto)
    //    {
    //        var auto = _mapper.Map<Autotransport>(dto);

    //        await _appDbContext.Autotransports.AddAsync(auto);
    //        await _appDbContext.SaveChangesAsync();

    //        var readDto = _mapper.Map<AutotransportReadFullDto>(dto);

    //        return CreatedAtAction(nameof(GetAutotransportById), new { Id = readDto.Id }, readDto);
    //    }

    //    //[HttpGet]   /// DONE
    //    //public async Task<IActionResult> AutotransportFullGet()
    //    //{
    //    //    var auto = await _appDbContext.Autotransports.ToListAsync();

    //    //    if (auto == null)
    //    //        return NotFound();

    //    //    return Ok(auto);
    //    //}

    //    [HttpGet]
    //    public async Task<ActionResult<AutotransportReadFullDto>> GetAutotransports()
    //    {
    //        try
    //        {
    //            var auto = await _appDbContext.Autotransports.ToListAsync();

    //            if (auto == null)
    //                return NotFound();

    //            return Ok(_mapper.Map<AutotransportReadFullDto>(auto));
    //        }
    //        catch (System.Reflection.TargetInvocationException ex)
    //        {
    //            Debug.WriteLine("Orig: " + ex.InnerException.Message);
    //            Debug.WriteLine("Orig stack trace: " + ex.InnerException.StackTrace);

    //            throw ex.InnerException;

    //            return BadRequest();
    //        }
    //        catch (Exception ex) { Debug.WriteLine("Othe ex: " + ex.Message); return BadRequest(); }
    //    }

    //    [HttpGet("{Id}")]
    //    public async Task<IActionResult> GetAutotransportById(Guid Id)
    //    {
    //        var auto = await _appDbContext.Autotransports
    //            .FirstOrDefaultAsync(a => a.Id == Id);

    //        if (auto == null)
    //            return NotFound(Id);

    //        return Ok(auto);
    //    }
    //}
}