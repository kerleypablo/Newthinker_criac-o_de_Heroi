using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder.Deletar;
using System;


namespace aula2.UseCases.Poder
{
    public class RemoverPoderUseCase : IRemoverPoderUseCase
    {
        private IRepositorioPoder _repositorioPoder;

        public RemoverPoderUseCase(IRepositorioPoder repositorioHeroi, IPoderAdapter adapter)
        {
            _repositorioPoder = repositorioHeroi;
        }
        public DeletarPoderResponse Executar(int id)
        {
            var response = new DeletarPoderResponse();
            try
            {
                _repositorioPoder.Remover(id);

                response.msg = "removido com sucesso";
                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao remover Poder";
                return response;
            }
        }
    }
}
