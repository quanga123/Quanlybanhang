
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlybanhang.Controllers
{
    public class AccController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            
            if (username == "admin" && password == "admin")
            {
                HttpContext.Session.SetString("KeyLogin", "123");
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.SuccessBody = TempData["successBody"] = "tài khoản hoặc mật khẩu không chính xác !";
                return Redirect("/Acc/Login");
            }
        }
    }
}
