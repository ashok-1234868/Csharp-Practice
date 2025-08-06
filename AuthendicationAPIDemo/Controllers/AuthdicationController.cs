using AuthendicationAPIDemo.DbContextCoonections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthendicationAPIDemo.DTO;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using AuthendicationAPIDemo.Models;
using AutoMapper;

namespace AuthendicationAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthdicationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public AuthdicationController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //[HttpGet("show")]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        var users = _context.UserTable.ToList();
        //        return Ok(new { message = "successful!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Internal server error: " + ex.Message);
        //    }
        //}
        [HttpPost("login")]
        public IActionResult Login([FromBody] Models.UserAuthendication user)
        {
            if (user == null || string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Invalid login data.");
            }

            // 🔍 Check DB for matching username and password
            var existingUser = _context.UserTable
                .FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

            if (existingUser == null)
            {
                return Unauthorized(new { message = "Invalid username or password." });
            }

            // ✅ Login success
            return Ok(new { message = "Login successful!" });
        }
        [HttpPut("update")]
        public IActionResult UpdateUser([FromBody] Models.UserAuthendication user)
        {
            if (user == null || string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Invalid user data.");
            }
            // 🔍 Check DB for existing user
            var existingUser = _context.UserTable
                .FirstOrDefault(u => u.UserName == user.UserName);
            if (existingUser == null)
            {
                return NotFound(new { message = "User not found." });
            }
            // ✅ Update user details
            existingUser.Password = user.Password;
            _context.SaveChanges();
            return Ok(new { message = "User updated successfully!" });
        }
        //registeration
        [HttpPost("register")]
        public IActionResult Register([FromBody] DummyUser dummy)
        {
            if (dummy == null || string.IsNullOrEmpty(dummy.UserName) || string.IsNullOrEmpty(dummy.Password))
            {
                return BadRequest("Invalid registration data.");
            }
            // 🔍 Check if user already exists
            var existingUser = _context.UserTable
                .FirstOrDefault(u => u.UserName == dummy.UserName);
            if (existingUser != null)
            {
                return Conflict(new { message = "User already exists." });
            }
            var user = _mapper.Map<UserAuthendication>(dummy);

            // ✅ Add new user to the database
            _context.UserTable.Add(user);
            _context.SaveChanges();
            return Ok(new { message = "Registration successful!" });
        }
        // delete user 
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            // 🔍 Find user by ID
            var user = _context.UserTable.Find(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }
            // ✅ Remove user from the database
            _context.UserTable.Remove(user);
            _context.SaveChanges();
            return Ok(new { message = "User deleted successfully!" });
        }

        //show all users
        [HttpGet("show")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _context.UserTable.ToList();
                if (users.Count == 0)
                {
                    return NotFound(new { message = "No users found." });
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }




    }
}
