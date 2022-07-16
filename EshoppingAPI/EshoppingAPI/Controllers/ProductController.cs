using EshoppingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EshoppingDBContext db;
        public ProductController(EshoppingDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }
        [HttpPost]
        public String post([FromBody] Product tp)
        {
            db.Products.Add(tp);
            db.SaveChanges();
            return "success";
        }
    }
}