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
        //private readonly CommomContext _commomContext;
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public UserController(IUserRepository userRepository/*, CommomContext commomContext*/)
        {
            _userRepository = userRepository;
            //_commomContext = commomContext;
        }

        public IActionResult AddUsuario(Cliente cliente)
        {
            //CHAMAR O REPOSITORIO PARA SALVAR
            if (!string.IsNullOrEmpty(cliente.Senha))
            {
                _userRepository.AdicionarCliente(cliente);
            }

            //DAR UM RETORNO PARA A TELA.
            return View();
        }

        public IActionResult LoginUsuario(Cliente cliente)
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