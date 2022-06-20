using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        EcommerceDBContext ec;
        public UserController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<UserTable> Get()
        {
            return ec.UserTables;
        }
        [HttpPost]
        public string Post([FromBody] UserTable user)
        {
            ec.UserTables.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
