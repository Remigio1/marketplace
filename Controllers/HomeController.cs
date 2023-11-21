using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUsuario()
        {
            return View();
        }

        public IActionResult LoginUsuario()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }


        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Prod1notebook()
        {
            return View();
        }

        public IActionResult Prod1game()
        {
            return View();
        }

        public IActionResult Prod1roupa()
        {
            return View();
        }

        public IActionResult Prod1carro()
        {
            return View();
        }

        public IActionResult Prod1smartphone()
        {
            return View();
        }

        public IActionResult Prod1livro()
        {
            return View();
        }

        public IActionResult Prod1movel()
        {
            return View();
        }

        public IActionResult Prod1eletrodomestico()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}