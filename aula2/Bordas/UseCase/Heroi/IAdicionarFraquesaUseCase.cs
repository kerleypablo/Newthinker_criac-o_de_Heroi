using aula2.DTO.Heroi.AdicionarFraquesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Heroi
{
    public interface IAdicionarFraquesaUseCase
    {

        AdicionarFraquesaresponse Executar(AdicionarFraquesaRequest request);

    }
}
