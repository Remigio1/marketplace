using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult AddUsuario(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(cliente.Senha))
            {
                _userRepository.AdicionarCliente(cliente);
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult LoginUsuario(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Senha) && string.IsNullOrEmpty(cliente.Email))
            {
                return View();
            }
            else
            {
                bool usuarioLogado = _userRepository.LoginUsuario(cliente);

                if (usuarioLogado)
                {
                    return View("Index");
                }
                else
                {
                    return View();
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}