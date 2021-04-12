using aula2.DTO.Heroi.DeletarHeroi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Heroi
{
    public interface IDeletarHeroiUseCase
    {
        DeletarHeroiResponse Executar(DeletarHeroiRequest request);
    }
}
