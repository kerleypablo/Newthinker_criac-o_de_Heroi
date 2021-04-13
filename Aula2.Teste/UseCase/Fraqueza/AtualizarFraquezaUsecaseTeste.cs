using aula2.Bordas.Adapter;
using Moq;
using Xunit;
using FluentAssertions;
using aula2.Bordas.Repositorio;
using aula2.UseCases.Poder;
using aula2.DTO.Poder.Atulizar;
using Aula2.Teste.UseCase.Builder;
using aula2.UseCases.Fraquesa;
using aula2.DTO.Fraquesa.Atulizar;

namespace Aula2.Teste.UseCase.Heroi
{
    public class AtualizarFraquezaUsecaseTeste
    {
        private readonly Mock<IRepositorioFraqueza> _repositorioFraqueza;
        private readonly Mock<IFraquezaAdapter> _FraquezaAdapter;
        private readonly AtualizarFraquezaUseCase _UseCase;

        public AtualizarFraquezaUsecaseTeste()
        {
            _repositorioFraqueza = new Mock<IRepositorioFraqueza>();
            _FraquezaAdapter = new Mock<IFraquezaAdapter>();
            _UseCase = new AtualizarFraquezaUseCase(_repositorioFraqueza.Object, _FraquezaAdapter.Object);
        }

        [Fact]
        public void Heroi_Atualizar_Fraqueza_quando_RetornarSucesso()
        {
            //arrange
            var request = new AtualizarFraquezaRequestBuilder().Build();
            var response = new AtualizarFraquezaReponse();
            var fraqueza = new aula2.entities.Fraqueza();
            fraqueza.id = 0;
            response.msg = "adicionado com sucesso";
            _repositorioFraqueza.Setup(repositorio => repositorio.Add(fraqueza)).Returns(fraqueza.id);
            _FraquezaAdapter.Setup(adapter => adapter.ConvertRequestParaFraqueza(request)).Returns(fraqueza);

            //act
            var result = _UseCase.Executar(fraqueza.id, request);

            //assert 
            response.Should().BeEquivalentTo(result);
        }
    }
}
