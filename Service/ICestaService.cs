using FeiraDoPedro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraDoPedro.Service
{
    public interface ICestaService
    {
        bool create(Cesta c);//no create a interface recebe um objeto do tipo Veiculo exige que o retorno seja um boolean!!
        bool delete(int? id);//o delete recebe um id e retorna um boolean
        Cesta get(int? id);//o get recebe um id e retorna um veiculo
        bool update(Cesta cesta);//n
    }
}
