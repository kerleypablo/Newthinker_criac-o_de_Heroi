using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa;


namespace aula2.UseCases.Fraquesa
{
    public class ObterFraquezaUseCase : IObterFraquezaUseCase
    {
        private IRepositorioFraqueza _repositorioFraqueza;
        private readonly IFraquezaAdapter _adapter;

        public ObterFraquezaUseCase(IRepositorioFraqueza repositorioFraqueza, IFraquezaAdapter adapter)
        {
            _repositorioFraqueza = repositorioFraqueza;
            _adapter = adapter;
        }

        public FraquezaResponse Executar(int id)
        {
            var fraqueza = _repositorioFraqueza.Obter(id);
            var fraquezaResponse = _adapter.ConvertFraquezaParaFraquezaResponse(fraqueza);
            return fraquezaResponse;
        }


    }

}
