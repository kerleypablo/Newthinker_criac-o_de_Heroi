using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.Deletar;
using aula2.Repositorio;
using System;

namespace aula2.UseCases.Heroi
{
    public class DeletarHeroiUseCase : IDeletarHeroiUseCase
    {
        private IRepositorioHeroi _repositorioHeroi;

        public DeletarHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
        {
            _repositorioHeroi = repositorioHeroi;
        }

        public DeletarHeroiResponse Executar(int id)
        {
            var response = new DeletarHeroiResponse();
            try
            {
                _repositorioHeroi.Remover(id);

                response.msg = "removido com sucesso";
                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao remover heroi";
                return response;
            }
        }
    }
}
