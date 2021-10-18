using FeiraDoPedro.Data;
using FeiraDoPedro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Services
{
    public class ProdutoService : IProdutoService
    {
        FeiraDoPedroContext _context;
        public ProdutoService(FeiraDoPedroContext context)
        {
            _context = context;
        }

        public List<Produto> getAll()
        {
            var lista = _context.Produtos.ToList();
            return lista;            
        }
        public bool create(Produto produto)
        {
            try
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Produto get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public bool update(Produto v)
        {
            try
            {
                _context.Produtos.Update(v);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            try
            {
                _context.Produtos.Remove(get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
