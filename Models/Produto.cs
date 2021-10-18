using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Models
{
    public class Produto 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto!")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Insira a imagem do produto")]
        [Display(Name = "Foto")]
        public string Foto { get; set; }
        //public int CestaId { get; set; }
        public Cesta Cesta { get; set; }


    }
}
