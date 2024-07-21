using CyerXProTeste.Models;
using CyerXProTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyerXProTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var authors = await _authorService.GetAuthorByIdAsync(id);
            if (authors == null)
            {
                return NotFound();
            }
            return Ok(authors);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(authors);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _authorService.AddAuthorAsync(author);
            return CreatedAtAction(nameof(Get), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Author author)
        {
            if (id != author.Id)
            {
                return BadRequest();
            }
            await _authorService.UpdateAuthorAsync(author);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }
    }
}
