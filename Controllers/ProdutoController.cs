using FeiraDoPedro.Models;
using FeiraDoPedro.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Controllers
{
    //Controllers são responsáveis por trabalhar e buscar dados que serão utilizados para o usuário.
    public class ProdutoController : Controller
    {
        IProdutoService _produtoService; 
        
        public ProdutoController(IProdutoService produtoService)
        {            
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            return View(_produtoService.getAll());
        }


        [HttpGet]        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            if (!ModelState.IsValid) return View(produto);

            return _produtoService.create(produto) ?
                RedirectToAction(nameof(Index)) :
                View(produto);
        }


        public IActionResult Read(int? id) // localhost/Veiculo/Read/id?
        {
            Produto produto = _produtoService.get(id);
            return produto != null ?
                View(produto) :
                NotFound();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Update(int? id)
        {
            var veiculo = _produtoService.get(id);
            return veiculo != null ? 
                View(veiculo) :                
                NotFound(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Produto produto)
        {
            if (!ModelState.IsValid) return View(produto);
            
            if (_produtoService.update(produto)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(produto);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (_produtoService.delete(id)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
