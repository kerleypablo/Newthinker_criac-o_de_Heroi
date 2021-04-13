
using aula2.DTO.Heroi;
using System.Collections.Generic;

namespace aula2.UseCases.Heroi
{
    public interface IListarHeroiUseCase
    {
        IEnumerable<HeroiResponse> Executar();

    }
}
