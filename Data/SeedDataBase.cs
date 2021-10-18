using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeiraDoPedro.Models;

namespace FeiraDoPedro.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<FeiraDoPedroContext>();
                context.Database.Migrate();// update-database

                if (context.Produtos.Any())
                {
                    return; 
                }
                context.Produtos.Add(new Produto { Nome = "Coco-da-Bahia", Preco = 3.00, Foto = "https://static7.depositphotos.com/1018248/732/i/600/depositphotos_7320383-stock-photo-coconut-isolated.jpg" });
                context.Produtos.Add(new Produto { Nome = "Abobora", Preco = 7.25, Foto = "https://www.soflor.com.br/wp-content/uploads/2015/04/compra-de-sementes-abobora-paulista-2-6-e1496362318889.jpg" });
                context.Produtos.Add(new Produto { Nome = "Ovo", Preco = 9.50, Foto = "https://www.almanaquedamulher.com/wp-content/uploads/2020/06/Ovo-1.png" });
                context.SaveChanges();
            }
        }
    }
}


