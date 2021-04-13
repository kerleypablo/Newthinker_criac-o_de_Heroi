
using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.Atualizar;
using aula2.Repositorio;
using System;

namespace aula2.UseCases.Heroi
{
    public class AtualizarHeroiUseCase : IAtualizarHeroiUseCase
    {
        private IRepositorioHeroi _repositorioHeroi;
        private readonly IHeroiAdapter _adapter;

        public AtualizarHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
        {
            _repositorioHeroi = repositorioHeroi;
            _adapter = adapter;
        }

        public AtualizarHeroiResponse Executar(int id, AtualizarHeroiRequest request)
        {
            var response = new AtualizarHeroiResponse();
            try
            {
                var HeroiAdicionar = _adapter.ConvertAtualizarHeroiRequestParaHeroi(request);
                _repositorioHeroi.Atualizar(HeroiAdicionar);

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
