
using aula2.DTO.Poder.Adicionar;

namespace aula2.UseCases.Heroi
{
    public interface IAdicionarPoderUseCase
    {
        AdicionarPoderResponse Executar(AdicionarPoderRequest request);
    }
}
