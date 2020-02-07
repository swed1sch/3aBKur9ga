using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmokeTube.Models;

namespace SmokeTube.Controllers
{
    public class PokurController : Controller
    {
        private IPokur pokurRepository;
        
        public PokurController(IPokur repo)
        {
            pokurRepository = repo;
        }
        public IActionResult AddPokur() => View();
        [HttpPost]
        public IActionResult AddPokur(Pokur pokur)
        {
            pokurRepository.AddPokur(pokur);
            return RedirectToAction(nameof(Pokurs));
        }
        public ViewResult Index() => View();
        public ViewResult Pokurs() => View(pokurRepository.Pokurs);
    }
}
