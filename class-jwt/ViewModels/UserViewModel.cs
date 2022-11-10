using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using class_jwt.Models;

namespace class_jwt.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}