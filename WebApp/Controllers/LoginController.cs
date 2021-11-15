using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(Kullanici kullanici)
        {
            if (kullanici.KullaniciAdi == "ahmed" && kullanici.Sifre == "123123Aa")
            {
                return View("LoginSuccess", kullanici);
            } else
            {
                return View("LoginFailure", kullanici);
            }
            
        }
    }
}
