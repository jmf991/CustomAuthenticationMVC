using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationMVC.Models
{
    public class LoginView
    {
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
    }
}