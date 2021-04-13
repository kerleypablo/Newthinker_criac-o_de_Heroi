using aula2.DTO.Poder.Atulizar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Poder
{
    public interface IAtualizarPoderUseCase
    {
        AtulizarPoderReponse Executar(int id, AtualizarPoderRequest request);
    }
}
