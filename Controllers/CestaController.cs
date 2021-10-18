using FeiraDoPedro.Models;
using FeiraDoPedro.Service;
using FeiraDoPedro.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Controllers
{
    public class CestaController : Controller
    {
        IProdutoService _produtoService;
        ICestaService _cestaService;
        public CestaController(IProdutoService produtoService, ICestaService cestaService)
        {
            _produtoService = produtoService;
            _cestaService = cestaService;
        }

        [HttpPost]
        public IActionResult AdicionarItem(int Id)
        {
            var produto = _produtoService.get(Id);
            var cesta = _cestaService.get(1);
            cesta.Produtos.Add(produto);
            _cestaService.update(cesta);
            return View();
        }

        [HttpDelete]
        public IActionResult RemoverItem(int Id)
        {
            var produto = _produtoService.get(Id);
            var cesta = _cestaService.get(1);
            cesta.Produtos.Remove(produto);
            _cestaService.update(cesta);
            return View();
        }


        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cesta cesta)
        {
            if (!ModelState.IsValid) return View();

            return _cestaService.create(cesta) ?
                RedirectToAction(nameof(Index)) :
                View();
        }
    }
}
