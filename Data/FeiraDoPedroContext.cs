using FeiraDoPedro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Data
{
    public class FeiraDoPedroContext : IdentityDbContext
    {
        public FeiraDoPedroContext(DbContextOptions<FeiraDoPedroContext> options) : base(options)
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cesta> Cesta { get; set; }
    }
}
