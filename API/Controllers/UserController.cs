using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;
        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        
        

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _dataContext.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var user = await _dataContext.Users.FindAsync(id);
            if (user == null)
            {
                return BadRequest("user not found");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user) // if the object reciev as parameter is a primitive data type [FromBody] is required 
        {

            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();
            

            return Ok(_dataContext.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User request)
        {
            var user = await _dataContext.Users.FindAsync(request.Id);
            if (user == null)
            {
                return BadRequest("user not found");
            }

            user.Username = request.Username;
            user.Password = request.Password;
            user.Email = request.Email;
            
            await _dataContext.SaveChangesAsync();

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(Guid id)
        {
            var user = await _dataContext.Users.FindAsync(id);
            if (user == null)
            {
                return BadRequest("user not found");
            }
            _dataContext.Users.Remove(user);
            await _dataContext.SaveChangesAsync();
            return Ok(_dataContext.Users.ToListAsync());

        }
    }
}
