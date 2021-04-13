
using aula2.DTO.Fraquesa.Adicionar;
using aula2.DTO.Poder.Adicionar;
using Bogus;


namespace Aula2.Teste.UseCase.Builder
{
    class AdicionarFraquezaRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarFraquezaResquest _AdicionarFraqueza;
        public AdicionarFraquezaRequestBuilder()
        {
            _AdicionarFraqueza = new AdicionarFraquezaResquest();
            _AdicionarFraqueza.nome = _faker.Random.String(15);

        }

        public AdicionarFraquezaResquest Build()
        {
            return _AdicionarFraqueza;
        }
    }
}
