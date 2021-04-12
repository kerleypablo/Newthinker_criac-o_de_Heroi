
using aula2.DTO.Heroi;

namespace aula2.UseCases.Heroi
{
    public interface IRetornrHeroiPorIdUseCase
    {
        HeroiResponse Executar(int id);

    }
}
