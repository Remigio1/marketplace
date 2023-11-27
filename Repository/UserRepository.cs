using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {
        private CommomContext _commomContext;

        public UserRepository(CommomContext commomContext)
        {
            _commomContext = commomContext;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            //    _commomContext.Cliente.Add(cliente);
            //    _commomContext.SaveChanges();

            //IncluirVendendorNoSistema();

            //IncluirCarrinhoNoSistema();
        }

        public bool LoginUsuario(Cliente cliente)
        {
            return true;
            //return _commomContext.Cliente.ToList().Where(x => 
            //                                             x.Email == cliente.Email && x.Senha == cliente.Senha)
            //                                             .Count() > 0;
        }

        public void AdicionaProdutoNoCarrinho(Produto produto)
        {
            //IncluirCarrinhoProdutoNoSistema();

            //_commomContext.Produto.Add(produto);
            //_commomContext.SaveChanges();
        }

        private void IncluirVendendorNoSistema()
        {
            Vendedor vendedor = new Vendedor()
            {
                Id = 1,
                RazaoSocial = "José de Souza",
                NomeFantasia = "LulaVendas",
                Email = "lula@gmail.com",
                Senha = "daioj23",
                CNPJ = "13245648",
                Comissao = 10,
                Endereco_Id = 1,
            };

            _commomContext.Vendedor.Add(vendedor);
            _commomContext.SaveChanges();
        }

        private void IncluirCarrinhoNoSistema()
        {
            Carrinho carrinho = new Carrinho()
            {
                Id = 1,
                DataPedido = new DateTime(),
                ValorTotal = 62900,
                StatusPedido_Id = 1,
                Cliente_Id = 1
            };

            _commomContext.Carrinho.Add(carrinho);
            _commomContext.SaveChanges();
        }

        private void IncluirCarrinhoProdutoNoSistema()
        {
            CarrinhoProduto carrinhoProduto = new CarrinhoProduto()
            {
                Quantidade = 2,
                Total = 62900,
                Carrinho_Id = 1,
                Produto_Id = 1
            };

            _commomContext.CarrinhoProduto.Add(carrinhoProduto);
            _commomContext.SaveChanges();
        }

        public Produto LeiaCarrinhoDoBancoDeDados()
        {
            return _commomContext.Produto.ToList().First();
        }

        public void EditarCarrinhoDoBancoDeDados(Produto prod)
        {
            _commomContext.Update(prod);
        }

        public void AdicionarCarrinhoDoBancoDeDados(Produto prod)
        {
            _commomContext.Produto.Add(prod);
            _commomContext.SaveChanges();
        }

        public void ExcluirCarrinhoDoBancoDeDados(Produto prod)
        {
            _commomContext.Remove(prod);
        }
    }
}

