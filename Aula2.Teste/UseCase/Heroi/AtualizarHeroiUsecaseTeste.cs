using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.Adicionar;
using aula2.Repositorio;
using aula2.UseCases.Heroi;
using Moq;
using Xunit;
using aula2.entities;
using FluentAssertions;
using Aula2.Teste.UseCase.Builder;
using aula2.DTO.Heroi.Atualizar;

namespace Aula2.Teste.UseCase.Heroi
{
    public class AtualizarHeroiUsecaseTeste
    {
        private readonly Mock<IRepositorioHeroi> _repositorioHeroi;
        private readonly Mock<IHeroiAdapter> _heroiAdapter;
        private readonly AdicionarHeroiUseCase _UseCase;

        public AtualizarHeroiUsecaseTeste()
        {
            _repositorioHeroi = new Mock<IRepositorioHeroi>();
            _heroiAdapter = new Mock<IHeroiAdapter>();
            _UseCase = new AdicionarHeroiUseCase(_repositorioHeroi.Object, _heroiAdapter.Object);
        }

        [Fact]
        public void Heroi_Atualizar_Heroi_quando_RetornarSucesso()
        {
            //arrange
            var request = new AtualizarHeroiRequestBuilder().Build();
            var response = new AtualizarHeroiResponse();
            var heroi = new aula2.entities.Heroi();
            heroi.id = 0;
            response.msg = "adicionado com sucesso";
            _repositorioHeroi.Setup(repositorio => repositorio.Add(heroi)).Returns(heroi.id);
            _heroiAdapter.Setup(adapter=>adapter.ConvertRequestParaHeroi(request)).Returns(heroi);

            //act
            var result = _UseCase.Executar(request);

            //assert 
            response.Should().BeEquivalentTo(result);
        }
    }
}
