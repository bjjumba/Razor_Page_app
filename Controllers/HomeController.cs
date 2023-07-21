using System.Web;
﻿using Microsoft.AspNetCore.Mvc;
using CoolApp.Models;
using System.Collections.Generic;

namespace CoolApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusicManager _musicManager;
        public HomeController(IMusicManager musicManager)
        {
            _musicManager = musicManager;
        }
        public IActionResult Index()
        {
            var music = _musicManager.GetAllMusic();
            return View(music);
        }
    }
}