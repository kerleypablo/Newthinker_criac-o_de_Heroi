using aula2.Bordas.Adapter;
using aula2.DTO.Heroi;
using aula2.DTO.Heroi.Adicionar;
using aula2.entities;
using System;

namespace aula2.Adapter
{
    public class HeroiAdapter : IHeroiAdapter
    {
        public HeroiResponse ConvertHeroiParaHeroiResponse(Heroi heroi)
        {
            throw new NotImplementedException();
        }

        public Heroi ConvertHeroiRequestParaHeroi(AdicionarHeroiRequest request)
        {
            var novoHeroi = new Heroi();
            novoHeroi.nome = request.nome;
            novoHeroi.poderid = request.poderid;
            novoHeroi.fraquesaid = request.fraquesaid;
            return novoHeroi;
        }
    }
}
