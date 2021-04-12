
using aula2.DTO.Heroi.Adicionar;

namespace aula2.UseCases.Heroi
{
    public interface IAdicionarHeroiUseCase
    {
        AdicionarHeroiResponse Executar(AdicionarHeroiRequest request);

    }
}
