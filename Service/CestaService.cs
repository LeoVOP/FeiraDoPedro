using FeiraDoPedro;
using FeiraDoPedro.Data;
using FeiraDoPedro.Models;
using FeiraDoPedro.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Services
{
    public class CestaService : ICestaService
    {
        FeiraDoPedroContext _context;
        
        public CestaService(FeiraDoPedroContext context)
        {
            _context = context;
        }

        public List<Cesta> getAll()
        {
            return _context.Cesta.ToList();
        }

        //public List<Cesta> FindAllProduto(int id)
        //{
        //    return _context.Cesta.Include(p => p.Itens).FirstOrDefault(b => b.Id == id);
        //}

        public bool create(Cesta c)
        {            
            try
            {
                _context.Cesta.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Cesta get(int? id)
        {
            return _context.Cesta.Include(c => c.Produtos).FirstOrDefault(c => c.Id == id);
        }        

        public bool update(Cesta v)
        {
            try
            {
                _context.Cesta.Update(v);
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
                _context.Cesta.Remove(get(id));
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
