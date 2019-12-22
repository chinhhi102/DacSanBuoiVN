using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DacSan.Models
{
    public class UsersModel
    {
        public int UserID { get; set; }
        public string PasswordID { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
    }
}