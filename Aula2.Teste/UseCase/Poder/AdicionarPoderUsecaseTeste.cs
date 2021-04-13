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
using aula2.UseCases.Poder;
using aula2.DTO.Poder.Adicionar;

namespace Aula2.Teste.UseCase.Poder
{
    public class AdicionarPoderUsecaseTeste
    {
        private readonly Mock<IRepositorioPoder> _repositorioPoder;
        private readonly Mock<IPoderAdapter> _poderAdapter;
        private readonly AdicionarPoderUseCase _UseCase;

        public AdicionarPoderUsecaseTeste()
        {
            _repositorioPoder = new Mock<IRepositorioPoder>();
            _poderAdapter = new Mock<IPoderAdapter>();
            _UseCase = new AdicionarPoderUseCase(_repositorioPoder.Object, _poderAdapter.Object);
        }

        [Fact]
        public void Poder_Adicionar_Heroi_quando_RetornarSucesso()
        {
            //arrange
            var request = new AdicionarPoderRequestBuilder().Build();
            var response = new AdicionarPoderResponse();
            var poder = new aula2.entities.Poder();
            poder.id = 0;
            response.msg = "adicionado com sucesso";
            response.id = poder.id;
            _repositorioPoder.Setup(repositorio => repositorio.Add(poder)).Returns(poder.id);
            _poderAdapter.Setup(adapter=>adapter.ConvertRequestParaPoder(request)).Returns(poder);

            //act
            var result = _UseCase.Executar(request);

            //assert 
            response.Should().BeEquivalentTo(result);
        }
    }
}
