using aula2.Bordas.Adapter;
using aula2.DTO.Heroi;
using aula2.DTO.Heroi.Adicionar;
using aula2.DTO.Heroi.Atualizar;
using aula2.entities;
using System;

namespace aula2.Adapter
{
    public class HeroiAdapter : IHeroiAdapter
    {
        public HeroiResponse ConvertHeroiParaHeroiResponse(Heroi herois)
        {
            var response = new HeroiResponse();
            response.nome = herois.nome;
            response.poderid = herois.poderid;
            response.fraquesaid = herois.fraquesaid;
            return response;
        }

        public Heroi ConvertAdicionarHeroiRequestParaHeroi(AdicionarHeroiRequest request)
        {
            return ConvertRequestParaHeroi(request);
        }

        public Heroi ConvertAtualizarHeroiRequestParaHeroi(AtualizarHeroiRequest request)
        {
            return ConvertRequestParaHeroi(request);
        }

        private Heroi ConvertRequestParaHeroi(HeroiRequest request)
        {
            var heroi = new Heroi();
            heroi.nome = request.nome;
            heroi.poderid = request.poderid;
            heroi.fraquesaid = request.fraquesaid;
            return heroi;
        }
    }
}
