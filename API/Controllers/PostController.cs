using API.Models;
using Microsoft.AspNetCore.Cors;
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

        [HttpPost("/addpost")]
        public async Task<ActionResult<List<User>>> AddPost(Post post) // if the object reciev as parameter is a primitive data type [FromBody] is required 
        {

            _dataContext.Posts.Add(post);
            await _dataContext.SaveChangesAsync();


            return Ok(_dataContext.Posts.ToListAsync());
        }
    }
}
