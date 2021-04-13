
using aula2.DTO.Heroi;

namespace aula2.UseCases.Heroi
{
    public interface IObterHeroiUseCase
    {
        HeroiResponse Executar(int id);

    }
}
