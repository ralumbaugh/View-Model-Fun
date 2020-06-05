using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            string message = "This is my message that I am sending to the page!";
            return View("Index", message);
        }

        public ViewResult Numbers()
        {
            int[] NumberList = {8,6,7,5,3,0,9};
            return View(NumberList);
        }

        public ViewResult Users()
        {
            List<User> MyUsers = new List<User>();
            MyUsers.Add(new User("Moose","Phillips"));
            MyUsers.Add(new User("Sarah",""));
            MyUsers.Add(new User("Jerry",""));
            MyUsers.Add(new User("Rene","Ricky"));
            MyUsers.Add(new User("Barbarah",""));
            // UserList MyUserlist = new UserList(MyUsers);
            return View(MyUsers);
        }

        public ViewResult SingleUser()
        {
            User myUser = new User("Moose", "Phillips");
            return View(myUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
