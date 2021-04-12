using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.DTO.Heroi.AdicionarFatnasia;

namespace aula2.UseCases.Heroi
{
    public interface IAdicionarFantasiaUseCase
    {

        Adicionarfantasiaresponse Executar(AdicionarFantasiaRequest request); 

    }
}
