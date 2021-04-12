using aula2.DTO.Heroi.RetornarHeroiPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Heroi
{
    public interface IRetornrHeroiPorIdUseCase
    {
        RetornarheroiPorIdResponse Executar(RetornarheroiPorIdRequest request);

    }
}
