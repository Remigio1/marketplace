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
    }
}

