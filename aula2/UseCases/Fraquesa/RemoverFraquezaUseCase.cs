using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa.Deletar;
using System;


namespace aula2.UseCases.Fraquesa
{
    public class RemoverFraquezaUseCase : IRemoverFraquezaUseCase
    {
        private IRepositorioFraqueza _repositorioFraqueza;

        public RemoverFraquezaUseCase(IRepositorioFraqueza repositorioFraqueza, IFraquezaAdapter adapter)
        {
            _repositorioFraqueza = repositorioFraqueza;
        }
        public DeletarFraquezaResponse Executar(int id)
        {
            var response = new DeletarFraquezaResponse();
            try
            {
                _repositorioFraqueza.Remover(id);

                response.msg = "removido com sucesso";
                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao remover Fraqueza";
                return response;
            }
        }
    }
}
