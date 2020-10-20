using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiSqliteSwagger.Models;

namespace DotNetCoreWebApiSqliteSwagger.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> { };
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetstringById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public void Poststring(User user)
        {

        }

        [HttpPut("{id}")]
        public void Putstring(int id, User user)
        {

        }

        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
           
        }
    }
}