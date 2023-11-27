using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        private readonly IUserRepository _userRepository;

        public CartController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            Produto prod = _userRepository.LeiaCarrinhoDoBancoDeDados();
            return View(prod); 
        }

        public IActionResult FazerPagamento()
        {
            return View();
        }

        public IActionResult EditarItem(Produto produto)
        {
            _userRepository.EditarCarrinhoDoBancoDeDados(produto);
            return View();
        }

        public IActionResult AdicionarItem(Produto produto)
        {
            _userRepository.AdicionarCarrinhoDoBancoDeDados(produto);
            return View();
        }

        public IActionResult ExcluirItem(Produto produto)
        {
            _userRepository.ExcluirCarrinhoDoBancoDeDados(produto);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}