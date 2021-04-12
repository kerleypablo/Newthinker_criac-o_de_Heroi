//using aula2.Bordas.Adapter;
//using aula2.DTO.Heroi.AdicionarHeroi;
//using aula2.Repositorio;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace aula2.UseCases.Heroi
//{

//    public class AdicionarHeroiUseCase : IAdicionarHeroiUseCase
//    {

//        private IRepositorioHeroi _repositorioHeroi;
//        private readonly IHeroiAdapter _adapter;

//        public AdicionarHeroiUseCase(IRepositorioHeroi repositorioHeroi, IHeroiAdapter adapter)
//        {
//            _repositorioHeroi = repositorioHeroi;
//            _adapter = adapter;
//        }

//        public AdicionarHeroiResponse Executar(AdicionarHeroiRequest request)
//        {
//            var response = new AdicionarHeroiResponse();
//            try
//            {

//                var HeroiAdicionar = _adapter.ConvertRequestParaProduto(request);
//                _repositorioHeroi.Add(HeroiAdicionar);
//                response.msg = "adicionado com sucesso";
//                return response;
//            }
//            catch (Exception)
//            {

//                response.msg = "Erro ao adicionar produto";
//                return response;
//            }

//        }




//    }


//}

 

