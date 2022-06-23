using EcommerceAPI.Models;
using EcommerceAPI.ViewModels;
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
    public class LoginController : ControllerBase
    {
        EcommerceDBContext db;
        public LoginController(EcommerceDBContext _db)
        {
            db = _db;
        }

        [HttpPost]
        [Route("login")]
        public bool Login(LoginViewModel loginViewModel)
        {
            if (db.LoginTables.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password))
            {
                return true;
            }
            return false;
        }
        [HttpPost]
        [Route("register")]
        public void Register(RegisterViewModel registerViewModel)
        {
            LoginTable loginTable = new LoginTable();
            loginTable.UserName = registerViewModel.UserName;
            loginTable.Password = registerViewModel.Password;
            db.LoginTables.Add(loginTable);
            db.SaveChanges();
        }
    }
}
