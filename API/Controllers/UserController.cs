using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(DataContext context) : ControllerBase
    {
        private readonly DataContext context = context;

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id: int}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = context.Users.Find(id);
            if(user == null)
            return NotFound();
            
            return user;
        }
        
    }
}