using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    }
}