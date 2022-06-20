using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Mytable> Get()
        {
            mangodbContext db = new mangodbContext();
            return db.Mytables.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            mangodbContext db = new mangodbContext();
            Mytable s = new Mytable();
            s.Text = sample;
            db.Mytables.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Mytable tblsample)
        {
            mangodbContext db = new mangodbContext();
            var tblsampleObj = db.Mytables.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Mytables.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            mangodbContext db = new mangodbContext();
            var tblsampleObj = db.Mytables.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Mytables.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
