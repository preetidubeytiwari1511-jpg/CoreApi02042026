using CoreApi02042026.Interfaces;
using CoreApi02042026.Model;
using CoreApi02042026.Models;
using CoreApi02042026.UserRepository;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoreApi02042026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly JwtService _jwtService;
        private readonly IUserRepository _repo;
        private readonly ISmsService _sms;

        public ProductController(JwtService jwtService, IUserRepository repo, ISmsService smsService)
        {
            _jwtService = jwtService;
            _repo = repo;
            _sms = smsService;

        }
        private static List<Product> products = new()
        {
            new Product { Id=1,Name="Product1",Description="first Product"},
            new Product { Id=2,Name="Product2",Description="Second Product"},
            new Product { Id=3,Name="Product3",Description="Third Product"},
            new Product { Id=4,Name="Product4",Description="Fourth Product"}
        };

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
        
            MstUser? user = await _repo.ValidateUser(request.Username, request.Password);
            APIResponse otpResObj = new APIResponse();
            if (user == null)
                return Unauthorized(new { Message = "Invalid username or password" });

            var token = _jwtService.GenerateToken(user.UserLoginId, user.UserLoginPass);
            if (token != null)
            {

                otpResObj= await _sms.SendSmsAsync(user);
               
            }
            return Ok(new LoginResponse
            {
                Token = token,
                Username = user.UserName,
                Role = otpResObj.msg,
                Expiry = DateTime.UtcNow.AddMinutes(60)
            });
        }
        //public  IActionResult Login([FromBody] LoginRequest request)
        //{
        //    // ✅ Step 1 — Validate the user credentials
        //    // In production: check against database with hashed passwords
        //    // This is just a hardcoded example:
        //    // var user = FakeUserStore.Validate(request.Username, request.Password);
        //    MstUser? user = await _repo.ValidateUser(dto.Username, dto.Password);

        //    if (user == null)
        //        return Unauthorized(new { Message = "Invalid username or password" });

        //    // ✅ Step 2 — Generate the JWT token
        //    var token = _jwtService.GenerateToken(request.Username, request.Password);

        //    // ✅ Step 3 — Return the token
        //    return Ok(new LoginResponse
        //    {
        //        Token = token,
        //        Username = request.Username,
        //       // Role = user.Role,
        //        Expiry = DateTime.UtcNow.AddMinutes(60)
        //    });
        //}
        // Anyone can call this — no token needed
        //public IActionResult Login([FromBody] LoginRequest request)
        //{
        //    // ✅ Step 1 — Validate the user credentials
        //    // In production: check against database with hashed passwords
        //    // This is just a hardcoded example:
        //    var user = FakeUserStore.Validate(request.Username, request.Password);

        //    if (user == null)
        //        return Unauthorized(new { Message = "Invalid username or password" });

        //    // ✅ Step 2 — Generate the JWT token
        //    var token = _jwtService.GenerateToken(user.Username, user.Role);

        //    // ✅ Step 3 — Return the token
        //    return Ok(new LoginResponse
        //    {
        //        Token = token,
        //        Username = user.Username,
        //        Role = user.Role,
        //        Expiry = DateTime.UtcNow.AddMinutes(60)
        //    });
        //}
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Product>> GetAll() => Ok(products);
        [HttpGet("{id}")]
        public ActionResult<Product> GetBYID(int id)
        {
            var result = products.FirstOrDefault(p => p.Id == id);
            return result is null ? NotFound() : Ok(result);
        }
        [HttpGet("AllUser")]
        public async Task<IActionResult> GetAllUSER()
        {
            var users = await _repo.GetAllUsers();
            return Ok(users);
        }
        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(GetBYID), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updated)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product is null) return NotFound();
            product.Name = updated.Name;
            product.Description = updated.Description;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product is null) return NotFound();
            products.Remove(product);
            return NoContent();
        }
    }

}
