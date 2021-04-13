
using aula2.DTO.Heroi.Atualizar;

namespace aula2.UseCases.Heroi
{
    public interface IAtualizarHeroiUseCase
    {
        AtualizarHeroiResponse Executar(int id, AtualizarHeroiRequest request);
    }
}
