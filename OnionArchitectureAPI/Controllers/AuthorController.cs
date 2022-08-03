using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly DataContext _context;
        public AuthorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> Get()
        {
            return Ok(await _context.Authors./*Include(x => x.Books).*/ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Author>>> Get(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
                return BadRequest("Author not found");
            return Ok(author);
        }
        [HttpPost]
        public async Task<ActionResult<List<Author>>> AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();

            return Ok(await _context.Authors.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Author>>> UpdateAuthor(Author request)
        {
            var dbAuthor = await _context.Authors.FindAsync(request.Id);
            if (dbAuthor == null)
                return BadRequest("Author not found");

            dbAuthor.Name = request.Name;
            dbAuthor.LastName = request.LastName;
            dbAuthor.Age = request.Age;

            await _context.SaveChangesAsync();

            return Ok(await _context.Authors.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Author>>> Delete(int id)
        {
            var dbAuthor = await _context.Authors.FindAsync(id);
            if (dbAuthor == null)
                return BadRequest("Author not found");

            _context.Authors.Remove(dbAuthor);
            await _context.SaveChangesAsync();

            return Ok(await _context.Authors.ToListAsync());
        }
    }
}
