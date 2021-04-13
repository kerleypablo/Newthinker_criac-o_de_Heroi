using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa.Atulizar;
using System;

namespace aula2.UseCases.Fraquesa
{
    public class AtualizarFraquezaUseCase : IAtualizarFraquezaUseCase
    {
        private IRepositorioFraqueza _repositorioFraqueza;
        private readonly IFraquezaAdapter _adapter;


        public AtualizarFraquezaUseCase(IRepositorioFraqueza repositorioFraqueza, IFraquezaAdapter adapter)
        {
            _repositorioFraqueza = repositorioFraqueza;
            _adapter = adapter;
        }
        
        public AtualizarFraquezaReponse Executar(int id, AtualizarFraquezaRequest request)
        {
            var response = new AtualizarFraquezaReponse();
            try
            {
                var FraquezaAdicionar = _adapter.ConvertAtualizarFraquezaRequestParaFraqueza(request);
                _repositorioFraqueza.Atualizar(FraquezaAdicionar);

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
