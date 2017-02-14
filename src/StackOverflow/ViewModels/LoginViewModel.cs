using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace StackOverflow.ViewModels
{
    public class LoginViewModel : Controller
    {

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
