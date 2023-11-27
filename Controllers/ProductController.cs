using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUserRepository _userRepository;

        public ProductController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }     

        public IActionResult Prod1carro()
        {           
            return View();
        }

        public IActionResult AddProd1carro()
        {
            Produto produto = new Produto();         
            produto.Preco = 62900;
            produto.Descricao = "Seminovo GRAND SIENA FLEX MT 1.4 4P 2021/2021 63.350 km rodados";
            produto.Categoria_Id = 1;
            produto.Vendedor_Id = 1;
            produto.Imagem = "~/prod1carro.png";
            produto.Status = true;

            _userRepository.AdicionaProdutoNoCarrinho(produto);

            return View("Carrinho");
        }     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}