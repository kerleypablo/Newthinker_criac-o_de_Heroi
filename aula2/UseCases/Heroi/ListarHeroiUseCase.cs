
using aula2.Bordas.Adapter;
using aula2.DTO.Heroi;
using aula2.Repositorio;
using System.Collections.Generic;

namespace aula2.UseCases.Heroi
{
    public class ListarHeroiUseCase : IListarHeroiUseCase
    {
        private IRepositorioHeroi _repositorioHeroi;
        private readonly IHeroiAdapter _adapter;

        public ListarHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
        {
            _repositorioHeroi = repositorioHeroi;
            _adapter = adapter;
        }

        public IEnumerable<HeroiResponse> Executar()
        {
            var herois = _repositorioHeroi.Listar();

            var heroisResponse = new List<HeroiResponse>();
            foreach (var heroi in herois)
            {
                var heroiResponse = _adapter.ConvertHeroiParaHeroiResponse(heroi);
                heroisResponse.Add(heroiResponse);
            }

            return heroisResponse;
        }
    }
}
