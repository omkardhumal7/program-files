using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class AdminTable
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
    }
}
