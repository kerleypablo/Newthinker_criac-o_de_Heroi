using aula2.Bordas.Adapter;
using aula2.DTO.Fraquesa;
using aula2.DTO.Fraquesa.Adicionar;
using aula2.DTO.Fraquesa.Atulizar;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Adapter
{
    public class FraquezaAdapter : IFraquezaAdapter
    {
        public Fraqueza ConvertAdicionarFraquezaRequestParaFraqueza(AdicionarFraquezaResquest request)
        {
            return ConvertRequestParaFraqueza(request);
        }

        public Fraqueza ConvertAtualizarFraquezaRequestParaFraqueza(AtualizarFraquezaRequest request)
        {
            return ConvertRequestParaFraqueza(request);
        }

        public FraquezaResponse ConvertFraquezaParaFraquezaResponse(Fraqueza fraqueza)
        {
            var response = new FraquezaResponse();
            response.nome = fraqueza.nome;
            return response;
        }

        private Fraqueza ConvertRequestParaFraqueza(FraquezaRequest request)
        {
            var fraqueza = new Fraqueza();
            fraqueza.nome = request.nome;
            return fraqueza;
        }
    }
}
