using aula2.DTO.Fraquesa.Atulizar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Fraqueza
{
    public interface IAtualizarFraquezaUseCase
    {
        AtualizarFraquezaReponse Executar(int id, AtualizarFraquezaRequest request);
    }
}
