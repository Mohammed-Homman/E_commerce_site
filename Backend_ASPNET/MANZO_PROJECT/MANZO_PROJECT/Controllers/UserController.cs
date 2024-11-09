using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASP_YETI_PROJECT.core.Models;
using MANZO_PROJECT.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MANZO_PROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromForm] UserSignUpModel model)
        {
            if (ModelState.IsValid)
            {
                // Check if the email is unique
                if (_dbContext.Users.Any(u => u.Email == model.Email))
                {
                    return BadRequest(new { Message = "Email is already in use" });
                }

                var user = new User
                {
                    UserName = model.Username,
                    Email = model.Email,
                    PasswordHash = HashPassword(model.Password),
                    ProfilePicture=model.ProfilePicture,
                    Country = model.Country,
                    Phone = model.Phone,
                    Desc = model.Desc,
                    IsSeller=model.IsSeller,

                };

               
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();

                return Ok(new { Message = "User registered successfully" });
            }

            return BadRequest(new { Errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)) });
        }
        [HttpGet("getallusers")]
        public IActionResult GetAllUsers()
        {
            var users = _dbContext.Users.ToList(); // Retrieve all users from the database

            // You might want to project the users into a DTO (Data Transfer Object) to send only necessary information to the client
            var userDtos = users.Select(u => new
            {
                UserId = u.UserId,
                UserName = u.UserName,
                Email = u.Email,
                IsSeller = u.IsSeller,
                ProfilePicture = u.ProfilePicture,
                Phone = u.Phone,
                Desc = u.Desc,
                Country = u.Country
            });

            return Ok(userDtos);
        }



        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromForm] UserSignInModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == loginModel.Email && u.PasswordHash==loginModel.Password);

                if (user != null && VerifyPassword(loginModel.Password, user.PasswordHash))
                {
                    

                    Response.Cookies.Append("authenticationCookie", "someTokenValue", new CookieOptions
                    {
                        HttpOnly = true,
                        Secure = true, // Set to true if using HTTPS
                        SameSite = SameSiteMode.Strict,
                       
                    });

                    var userDto = new User
                    {
                        UserId = user.UserId,
                        UserName = user.UserName,
                        Email = user.Email,
                        IsSeller=user.IsSeller,
                        ProfilePicture=user.ProfilePicture,
                        Phone=user.Phone,
                        Desc=user.Desc,
                        Country=user.Country
                      
                    };

                    return Ok(userDto);
                }

               
                return BadRequest(new { Message = "Invalid credentials" });
            }

            return BadRequest(new { Errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)) });
        }




        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Remove the authentication cookie
            Response.Cookies.Delete("authenticationCookie", new CookieOptions
            {
                Secure = true, // Set to true if using HTTPS
                SameSite = SameSiteMode.Strict,
                // Add other options as needed
            });

            return Ok(new { Message = "Logout successful" });
        }

        // Helper method to hash the password (use a proper password hashing library in production)
        private string HashPassword(string password)
        {
            // Implement your password hashing logic here (e.g., using BCrypt)
            // For simplicity, we're not implementing actual password hashing in this example
            return password;
        }

        // Helper method to verify the password (use a proper password hashing library in production)
        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            // Implement your password verification logic here (e.g., using BCrypt)
            // For simplicity, we're not implementing actual password verification in this example
            return enteredPassword == storedPasswordHash;
        }
    }
}
