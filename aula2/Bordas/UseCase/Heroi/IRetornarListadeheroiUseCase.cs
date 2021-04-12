
using aula2.DTO.Heroi;
using System.Collections.Generic;

namespace aula2.UseCases.Heroi
{
    public interface IRetornarListadeheroiUseCase
    {
        IEnumerable<HeroiResponse> Executar();

    }
}
