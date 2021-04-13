using aula2.DTO.Heroi.Adicionar;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Teste.UseCase.Builder
{
    class AdicionarHeroiRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarHeroiRequest _AdicionarHeroi;
        public AdicionarHeroiRequestBuilder()
        {
            _AdicionarHeroi = new AdicionarHeroiRequest();
            _AdicionarHeroi.nome = _faker.Random.String(15);
            _AdicionarHeroi.poderid = _faker.Random.Int(0);
            _AdicionarHeroi.fraquesaid = _faker.Random.Int(0);
            _AdicionarHeroi.fantasiaid = _faker.Random.Int(0);

        }

        public AdicionarHeroiRequest Build()
        {
            return _AdicionarHeroi;
        }
    }
}
