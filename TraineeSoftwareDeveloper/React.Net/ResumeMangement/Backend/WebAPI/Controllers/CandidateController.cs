using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Context;
using WebAPI.Core.DTOs.Candidate;
using WebAPI.Core.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ResumeDbContext _context;

        private readonly IMapper _mapper;

        public CandidateController(ResumeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCandidate([FromForm] CandidateCreateDTO dto, IFormFile pdfFile)
        {
            // 1- Save PDF to Server
            var fiveMB = 5 * 1024 * 1024;
            var pdfMineType = "application/pdf";
            if (pdfFile.Length > fiveMB || pdfFile.ContentType != pdfMineType)
            {
                return BadRequest("File is not valid.");
            }

            var resumeUrl = Guid.NewGuid().ToString() + ".pdf";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Documets", "pdfs", resumeUrl);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await pdfFile.CopyToAsync(stream);
            }

            // 2- Save URL into Entity
            var candidate = _mapper.Map<Candidate>(dto);
            candidate.ResumeUrl = resumeUrl;

            await _context.Candidates.AddAsync(candidate);
            await _context.SaveChangesAsync();

            return Ok(candidate);
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CandidateGetDTO>>> GetCandidates()
        {
            var candidates = await _context.Candidates.Include(c => c.Job).ToListAsync();
            var convertedCandidates = _mapper.Map<IEnumerable<CandidateGetDTO>>(candidates);


            return Ok(convertedCandidates);
        }

        // Read (Download PDF File)
        [HttpGet]
        [Route("download/{url}")]
        public IActionResult DownloadPdfFile(string url)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Documents", "pdfs", url);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File not found.");
            }

            var pdfBytes = System.IO.File.ReadAllBytes(filePath);
            var file = File(pdfBytes, "application/pdf", url);
            return file;
        }
    }
}
