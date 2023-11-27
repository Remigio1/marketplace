using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1.Repository
{
    public class CommomContext : DbContext
    {
        public CommomContext(DbContextOptions<CommomContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<CarrinhoProduto> CarrinhoProduto { get; set; }
    }
}

