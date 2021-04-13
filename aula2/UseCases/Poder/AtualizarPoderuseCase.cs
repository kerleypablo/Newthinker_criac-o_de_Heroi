using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder.Atulizar;
using System;


namespace aula2.UseCases.Poder
{
    public class AtualizarPoderuseCase : IAtualizarPoderUseCase
    {
        private IRepositorioPoder _repositorioPoder;
        private readonly IPoderAdapter _adapter;

        public AtualizarPoderuseCase(IRepositorioPoder repositorioPoder, IPoderAdapter adapter)
        {
            _repositorioPoder = repositorioPoder;
            _adapter = adapter;
        }


        public AtulizarPoderReponse Executar(int id, AtualizarPoderRequest request)
        {
            var response = new AtulizarPoderReponse();
            try
            {
                var PoderAdicionar = _adapter.ConvertAtualizarPoderRequestParaPoder(request);
                _repositorioPoder.Atualizar(PoderAdicionar);

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
