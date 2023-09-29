using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VSelectorsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _environment;
        public VSelectorsController(DataContext context,IWebHostEnvironment EV)
        {
            this._environment= EV;  
             _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<VCharacter>>> AddCharacter(VCharacter character)
        {
            var Path = this._environment.ContentRootPath ;
             var FilePath= 

            _context.VCharacters.Add(character);
            await _context.SaveChangesAsync();
            return Ok(await _context.VCharacters.ToListAsync());
        }
        [HttpGet]
        public async Task<ActionResult<List<VCharacter>>> GetAllCharacters()
        {
            return Ok(await _context.VCharacters.ToListAsync());

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<VCharacter>> GetCharacter(int id)
        {
            var character = await _context.VCharacters.FindAsync(id);
            if (character == null)
            {
                return BadRequest("Character not found");
            }
            return Ok(character);
        }

    }
}
