using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Context;
using WebAPI.Core.DTOs.Job;
using WebAPI.Core.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly ResumeDbContext _context;

        private readonly IMapper _mapper;

        public JobController(ResumeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDTO dto)
        {
            var job = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();

            return Ok(job);
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<JobGetDTO>>> GetJobs()
        {
            var jobs = await _context.Jobs.Include(j => j.Company).ToListAsync();
            var convertedJobs = _mapper.Map<IEnumerable<JobGetDTO>>(jobs);

            return Ok(convertedJobs);
        }
    }
}
