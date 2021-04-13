using aula2.Bordas.Adapter;
using aula2.DTO.Poder;
using aula2.DTO.Poder.Adicionar;
using aula2.DTO.Poder.Atulizar;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Adapter
{
    public class PoderAdapter : IPoderAdapter
    {
        public Poder ConvertAdicionarPoderRequestParaPoder(AdicionarPoderRequest request)
        {
            return ConvertRequestParaPoder(request);
        }

        public Poder ConvertAtualizarPoderRequestParaPoder(AtualizarPoderRequest request)
        {
            return ConvertRequestParaPoder(request);
        }

        public PoderResponse ConvertPoderParaPoderResponse(Poder poder)
        {
            var response = new PoderResponse();
            response.nome = poder.nome;
            return response;
        }
        public Poder ConvertRequestParaPoder(PoderRequest request)
        {
            var poder = new Poder();
            poder.nome = request.nome;
            return poder;
        }
    }
}
