using FeiraDoPedro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro

{
    public class Cesta
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public List<Produto> Produtos { get; set; }
        public double PrecoTotal { get; set; }
        public int NumeroUnico { get; set; }
        public float Quantidade { get; set; }
    }
}


