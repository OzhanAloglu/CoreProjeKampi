﻿using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Kamp.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
