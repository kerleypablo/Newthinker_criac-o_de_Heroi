
using aula2.DTO.Poder.Adicionar;
using Bogus;


namespace Aula2.Teste.UseCase.Builder
{
    class AdicionarPoderRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarPoderRequest _AdicionarPoder;
        public AdicionarPoderRequestBuilder()
        {
            _AdicionarPoder = new AdicionarPoderRequest();
            _AdicionarPoder.nome = _faker.Random.String(15);

        }

        public AdicionarPoderRequest Build()
        {
            return _AdicionarPoder;
        }
    }
}
