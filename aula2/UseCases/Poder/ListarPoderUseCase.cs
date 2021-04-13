using aula2.Bordas.Adapter;
using aula2.Bordas.Repositorio;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.UseCases.Poder
{
    public class ListarPoderUseCase : IListarPoderUseCase
    {
        private IRepositorioPoder _repositorioPoder;
        private readonly IPoderAdapter _adapter;

        public ListarPoderUseCase(IRepositorioPoder repositorioPoder, IPoderAdapter adapter)
        {
            _repositorioPoder = repositorioPoder;
            _adapter = adapter;
        }
      
            public IEnumerable<PoderResponse> Executar()
            {
                var poderes = _repositorioPoder.Listar();

                var heroisResponse = new List<PoderResponse>();
                foreach (var poder in poderes)
                {
                    var poderResponse = _adapter.ConvertPoderParaPoderResponse(poder);
                    heroisResponse.Add(poderResponse);
                }

                return heroisResponse;
            }
        }
    }

