using aula2.Bordas.Adapter;
using Moq;
using Xunit;
using FluentAssertions;
using aula2.Bordas.Repositorio;
using aula2.UseCases.Poder;
using aula2.DTO.Poder.Atulizar;
using Aula2.Teste.UseCase.Builder;

namespace Aula2.Teste.UseCase.Heroi
{
    public class AtualizarPoderUsecaseTeste
    {
        private readonly Mock<IRepositorioPoder> _repositorioHeroi;
        private readonly Mock<IPoderAdapter> _heroiAdapter;
        private readonly AtualizarPoderuseCase _UseCase;

        public AtualizarPoderUsecaseTeste()
        {
            _repositorioHeroi = new Mock<IRepositorioPoder>();
            _heroiAdapter = new Mock<IPoderAdapter>();
            _UseCase = new AtualizarPoderuseCase(_repositorioHeroi.Object, _heroiAdapter.Object);
        }

        [Fact]
        public void Heroi_Atualizar_Poder_quando_RetornarSucesso()
        {
            //arrange
            var request = new AtualizarPoderRequestBuilder().Build();
            var response = new AtulizarPoderReponse();
            var poder = new aula2.entities.Poder();
            poder.id = 0;
            response.msg = "adicionado com sucesso";
            _repositorioHeroi.Setup(repositorio => repositorio.Add(poder)).Returns(poder.id);
            _heroiAdapter.Setup(adapter => adapter.ConvertRequestParaPoder(request)).Returns(poder);

            //act
            var result = _UseCase.Executar(poder.id, request);

            //assert 
            response.Should().BeEquivalentTo(result);
        }
    }
}
