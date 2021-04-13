using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder.Adicionar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Poder
{
    public class AdicionarPoderUseCase : IAdicionarPoderUseCase
    {
        private IRepositorioPoder _repositorioPoder;
        private readonly IPoderAdapter _adapter;

        public AdicionarPoderUseCase(IRepositorioPoder repositorioPoder, IPoderAdapter adapter)
        {
            _repositorioPoder = repositorioPoder;
            _adapter = adapter;
        }
        public AdicionarPoderResponse Executar(AdicionarPoderRequest request)
        {
            var response = new AdicionarPoderResponse();
            try
            {
                var HeroiAdicionar = _adapter.ConvertAdicionarPoderRequestParaPoder(request);
                response.id = _repositorioPoder.Add(HeroiAdicionar);
                response.msg = "adicionado com sucesso";

                return response;
            }
            catch (Exception)
            {
                response.msg = "Erro ao adicionar Poder";
                return response;
            }
        }
    }
}
