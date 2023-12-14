using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Context;
using WebAPI.Core.DTOs.Company;
using WebAPI.Core.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ResumeDbContext _context;

        private readonly IMapper _mapper;

        public CompanyController(ResumeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDTO dto)
        {
            var company = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();

            return Ok(company);
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CompanyGetDTO>>> GetCompaies()
        {
            var companies = await _context.Companies.ToListAsync();
            var convertedCompanies = _mapper.Map<IEnumerable<CompanyGetDTO>>(companies);

            return Ok(convertedCompanies);
        }

        // Update 

        // Delete
    }

}
