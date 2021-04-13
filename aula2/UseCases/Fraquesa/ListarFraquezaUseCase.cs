using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa;
using System.Collections.Generic;


namespace aula2.UseCases.Fraquesa
{
    public class ListarFraquezaUseCase : IListarFraquezaUseCase
    {
        private IRepositorioFraqueza _repositorioFraqueza;
        private readonly IFraquezaAdapter _adapter;

        public ListarFraquezaUseCase(IRepositorioFraqueza repositorioFraqueza, IFraquezaAdapter adapter)
        {
            _repositorioFraqueza = repositorioFraqueza;
            _adapter = adapter;
        }
        public IEnumerable<FraquezaResponse> Executar()
        {
            var fraquezas = _repositorioFraqueza.Listar();

            var fraquezasResponse = new List<FraquezaResponse>();
            foreach (var fraqueza in fraquezas)
            {
                var FraquezaResponse = _adapter.ConvertFraquezaParaFraquezaResponse(fraqueza);
                fraquezasResponse.Add(FraquezaResponse);
            }

            return fraquezasResponse;
        }

    }
}
