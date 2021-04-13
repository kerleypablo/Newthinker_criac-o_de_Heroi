using aula2.DTO.Fraquesa.Atulizar;
using Bogus;


namespace Aula2.Teste.UseCase.Builder
{
    class AtualizarFraquezaRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarFraquezaRequest _AtualizarFraqueza;
        public AtualizarFraquezaRequestBuilder()
        {
            _AtualizarFraqueza = new AtualizarFraquezaRequest();
            _AtualizarFraqueza.nome = _faker.Random.String(15);

        }

        public AtualizarFraquezaRequest Build()
        {
            return _AtualizarFraqueza;
        }
    }
}
