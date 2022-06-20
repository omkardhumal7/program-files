using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        EcommerceDBContext ec;
        public AdminController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<AdminTable> Get()
        {
            return ec.AdminTables;
        }
        [HttpPost]
        public string Post([FromBody] AdminTable user)
        {
            ec.AdminTables.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
