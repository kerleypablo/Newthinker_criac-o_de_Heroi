using aula2.DTO.Heroi.Deletar;

namespace aula2.UseCases.Heroi
{
    public interface IRemoverHeroiUseCase
    {
        DeletarHeroiResponse Executar(int id);
    }
}
