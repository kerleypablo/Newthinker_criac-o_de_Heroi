using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.Adicionar;
using aula2.Repositorio;
using System;

namespace aula2.UseCases.Heroi
{
    public class AdicionarHeroiUseCase : IAdicionarHeroiUseCase
    {
        private IRepositorioHeroi _repositorioHeroi;
        private readonly IHeroiAdapter _adapter;

        public AdicionarHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
        {
            _repositorioHeroi = repositorioHeroi;
            _adapter = adapter;
        }

        public AdicionarHeroiResponse Executar(AdicionarHeroiRequest request)
        {
            var response = new AdicionarHeroiResponse();
            try
            {
                var HeroiAdicionar = _adapter.ConvertAdicionarHeroiRequestParaHeroi(request);
                response.id = _repositorioHeroi.Add(HeroiAdicionar);
                response.msg = "adicionado com sucesso";

                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao adicionar heroi";
                return response;
            }
        }
    }
}



