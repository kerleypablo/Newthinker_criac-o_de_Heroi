using aula2.DTO.Fraquesa.Deletar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Fraqueza
{
    public interface IRemoverFraquezaUseCase
    {
        DeletarFraquezaResponse Executar(int id);
    }
}
