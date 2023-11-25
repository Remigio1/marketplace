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
            try
            {
                _commomContext.Cliente.Add(cliente);
                _commomContext.SaveChanges();

                Console.Write("OK");
            }
            catch (Exception)
            {
                Console.Write("Erro");
                throw;
            }

        }
    }
}

