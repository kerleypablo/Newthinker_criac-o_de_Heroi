using aula2.DTO.Poder;
using System.Collections.Generic;


namespace aula2.Bordas.UseCase.Poder
{
    public interface IListarPoderUseCase
    {
        IEnumerable<PoderResponse> Executar();
    }
}
