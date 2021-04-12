
using aula2.DTO.Heroi.RetornarListadeHeroi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Heroi
{
    public interface IRetornarListadeheroiUseCase
    {
        RetornarListadeHeroiRequest Executar(RetornarListadeHeroiRequest request);

    }
}
