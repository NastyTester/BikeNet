using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly DataContext _dataContext;
        public PostController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("/feed")]
        public async Task<ActionResult<List<Post>>> GetAllPosts()
        {
            return Ok(await _dataContext.Posts.ToListAsync());
            
        }

        
    }
}
