using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder;


namespace aula2.UseCases.Poder
{
    public class ObterPoderUseCsae : IObterPoderUseCase
    {
        private IRepositorioPoder _repositorioPoder;
        private readonly IPoderAdapter _adapter;



        public ObterPoderUseCsae(IRepositorioPoder repositorioPoder, IPoderAdapter adapter)
        {
            _repositorioPoder = repositorioPoder;
            _adapter = adapter;
        }
        public PoderResponse Executar(int id)
        {
            var poder = _repositorioPoder.Obter(id);
            var poderResponse = _adapter.ConvertPoderParaPoderResponse(poder);
            return poderResponse;
        }
    }
}
