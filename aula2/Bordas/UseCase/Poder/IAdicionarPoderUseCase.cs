using aula2.DTO.Poder.Adicionar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Poder
{
    public interface IAdicionarPoderUseCase
    {
        AdicionarPoderResponse Executar(AdicionarPoderRequest request);
    }
}
