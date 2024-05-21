using ComplianceApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComplianceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplianceController : ControllerBase
    {
        private readonly ApplicationDbcontext _dbcontext;

        public ComplianceController( ApplicationDbcontext applicationDbcontext)

        {
            _dbcontext = applicationDbcontext;
        }
        
        [HttpPost("CreateEpisode")]
        public IActionResult AddEpisode(Episode episode)
        {
            if(episode == null)
            {
                return BadRequest("Please enter valid values");
            }
            _dbcontext.Episodes.Add(episode);
            _dbcontext.SaveChanges();
            return Ok(episode);
        }
        [HttpGet("GetAllEpisode")]
        public IActionResult GetEpisode()
        {
            // List<Episode> result = _dbcontext.Episodes.ToList();
            List<Episode> result = _dbcontext.Episodes.Include(i => i.ComplianceItems).ToList();
            return Ok(result);
        }
    }
}
