﻿using Microsoft.AspNetCore.Mvc;

namespace SuperFunCargoGame.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
