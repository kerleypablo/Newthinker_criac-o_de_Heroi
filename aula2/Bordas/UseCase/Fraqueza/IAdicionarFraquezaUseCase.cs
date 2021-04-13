using aula2.DTO.Fraquesa.Adicionar;
using aula2.DTO.Poder.Adicionar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Fraqueza
{
   public interface IAdicionarFraquezaUseCase
    {
        AdicionarFraquezaResponse Executar(AdicionarFraquezaResquest request);
    }
}
