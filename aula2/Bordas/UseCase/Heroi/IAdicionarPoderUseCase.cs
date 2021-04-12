using aula2.DTO.Heroi.AdicionarPoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Heroi
{
    public interface IAdicionarPoderUseCase
    {
        AdicionarPoderResponse Executar(AdicionarPoderRequest request);

    }
}
