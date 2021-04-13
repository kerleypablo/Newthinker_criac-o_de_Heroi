using aula2.DTO.Fraquesa;
using aula2.DTO.Fraquesa.Adicionar;
using aula2.DTO.Fraquesa.Atulizar;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.Adapter
{
    public interface IFraquezaAdapter
    {
        Fraqueza ConvertAdicionarFraquezaRequestParaFraqueza(AdicionarFraquezaResquest request);

        Fraqueza ConvertAtualizarFraquezaRequestParaFraqueza(AtualizarFraquezaRequest request);

        FraquezaResponse ConvertFraquezaParaFraquezaResponse(Fraqueza fraqueza);
    }
}
