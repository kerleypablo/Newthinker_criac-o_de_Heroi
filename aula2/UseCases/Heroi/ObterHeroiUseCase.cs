using aula2.Bordas.Adapter;
using aula2.DTO.Heroi;
using aula2.Repositorio;

namespace aula2.UseCases.Heroi
{
    public class ObterHeroiUseCase : IObterHeroiUseCase
    {
        private IRepositorioHeroi _repositorioHeroi;
        private readonly IHeroiAdapter _adapter;

        public ObterHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
        {
            _repositorioHeroi = repositorioHeroi;
            _adapter = adapter;
        }

        public HeroiResponse Executar(int id)
        {
            var heroi = _repositorioHeroi.Obter(id);
            var heroiResponse = _adapter.ConvertHeroiParaHeroiResponse(heroi);
            return heroiResponse;
        }
    }
}
