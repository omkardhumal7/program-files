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
    public class ProductController : ControllerBase
    {
        EcommerceDBContext ec;
        public ProductController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<ProductTable> Get()
        {
            return ec.ProductTables;
        }
        [HttpPost]
        public string Post([FromBody] ProductTable user)
        {
            ec.ProductTables.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
