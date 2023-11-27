using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IUserRepository
    {
        void AdicionarCliente(Cliente cliente);
        bool LoginUsuario(Cliente cliente);
        void AdicionaProdutoNoCarrinho(Produto produto);
        Produto LeiaCarrinhoDoBancoDeDados();
        void EditarCarrinhoDoBancoDeDados(Produto prod);
        void AdicionarCarrinhoDoBancoDeDados(Produto prod);
        void ExcluirCarrinhoDoBancoDeDados(Produto prod);
    }
}
