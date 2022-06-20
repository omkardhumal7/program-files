using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
