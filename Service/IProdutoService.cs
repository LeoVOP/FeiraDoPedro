using FeiraDoPedro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Services
{
    public interface IProdutoService
    {
        bool create(Produto produto);//no create a interface recebe um objeto do tipo Veiculo exige que o retorno seja um boolean!!
        bool delete(int? id);//o delete recebe um id e retorna um boolean
        Produto get(int? id);//o get recebe um id e retorna um veiculo
        List<Produto> getAll();// o getAll recebe uma string ou um boolean e retorna um lista(List) de Veiculo!!
        bool update(Produto p);//no update a interface recebe um objeto do tipo Veiculo exige que o retorno seja um boolean!!
    }
}
