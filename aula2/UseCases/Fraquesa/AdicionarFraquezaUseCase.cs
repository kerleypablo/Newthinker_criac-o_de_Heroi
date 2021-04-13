using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa.Adicionar;
using System;


namespace aula2.UseCases.Fraquesa
{
    public class AdicionarFraquezaUseCase : IAdicionarFraquezaUseCase
    {
        private IRepositorioFraqueza _repositorioFraqueza;
        private readonly IFraquezaAdapter _adapter;


        public AdicionarFraquezaUseCase(IRepositorioFraqueza repositorioFraqueza, IFraquezaAdapter adapter)
        {
            _repositorioFraqueza = repositorioFraqueza;
            _adapter = adapter;
        }

        public AdicionarFraquezaResponse Executar(AdicionarFraquezaResquest request)
        {
            var response = new AdicionarFraquezaResponse();
            try
            {
                var HeroiAdicionar = _adapter.ConvertAdicionarFraquezaRequestParaFraqueza(request);
                response.id = _repositorioFraqueza.Add(HeroiAdicionar);
                response.msg = "adicionado com sucesso";

                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao adicionar Fraqueza";
                return response;
            }
        }
    }

}
