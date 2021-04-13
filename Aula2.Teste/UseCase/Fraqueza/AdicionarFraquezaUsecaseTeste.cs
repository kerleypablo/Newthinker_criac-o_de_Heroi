using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.Adicionar;
using aula2.Repositorio;
using aula2.UseCases.Heroi;
using Moq;
using Xunit;
using aula2.entities;
using FluentAssertions;
using Aula2.Teste.UseCase.Builder;
using aula2.Bordas.Repositorio;
using aula2.UseCases.Fraquesa;
using aula2.DTO.Fraquesa.Adicionar;

namespace Aula2.Teste.UseCase.fraqueza
{
    public class AdicionarFraquezaUsecaseTeste
    {
        private readonly Mock<IRepositorioFraqueza> _repositorioFraqueza;
        private readonly Mock<IFraquezaAdapter> _fraquezaAdapter;
        private readonly AdicionarFraquezaUseCase _UseCase;

        public AdicionarFraquezaUsecaseTeste()
        {
            _repositorioFraqueza = new Mock<IRepositorioFraqueza>();
            _fraquezaAdapter = new Mock<IFraquezaAdapter>();
            _UseCase = new AdicionarFraquezaUseCase(_repositorioFraqueza.Object, _fraquezaAdapter.Object);
        }

        [Fact]
        public void Poder_Adicionar_Fraqueza_quando_RetornarSucesso()
        {
            //arrange
            var request = new AdicionarFraquezaRequestBuilder().Build();
            var response = new AdicionarFraquezaResponse();
            var fraqueza = new aula2.entities.Fraqueza();
            fraqueza.id = 0;
            response.msg = "adicionado com sucesso";
            response.id = fraqueza.id;
            _repositorioFraqueza.Setup(repositorio => repositorio.Add(fraqueza)).Returns(fraqueza.id);
            _fraquezaAdapter.Setup(adapter=>adapter.ConvertRequestParaFraqueza(request)).Returns(fraqueza);

            //act
            var result = _UseCase.Executar(request);

            //assert 
            response.Should().BeEquivalentTo(result);
        }
    }
}
