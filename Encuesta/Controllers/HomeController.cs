using Encuesta.Models;
using Encuesta.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Encuesta.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoriodeEncuesta repositorioEncuesta;

        public  HomeController(IRepositoriodeEncuesta repositorioEncuesta)
        {
           this.repositorioEncuesta = repositorioEncuesta;

        }

       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FormularioEncuesta()
        {
            return View();
        }
        [HttpPost]
       public IActionResult FormularioEncuesta(FormularioEncuesta formularioEncuesta)
        {
            repositorioEncuesta.FormularlaEncuesta(formularioEncuesta);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
