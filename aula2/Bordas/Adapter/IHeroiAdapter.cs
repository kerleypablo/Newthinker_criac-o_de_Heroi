using aula2.DTO.Heroi;
using aula2.DTO.Heroi.Adicionar;
using aula2.DTO.Heroi.Atualizar;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.Adapter
{
    public interface IHeroiAdapter
    {
        Heroi ConvertAdicionarHeroiRequestParaHeroi(AdicionarHeroiRequest request);

        Heroi ConvertAtualizarHeroiRequestParaHeroi(AtualizarHeroiRequest request);

        HeroiResponse ConvertHeroiParaHeroiResponse(Heroi heroi);

        Heroi ConvertRequestParaHeroi(HeroiRequest request);
    }
}
