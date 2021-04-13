using aula2.DTO.Heroi.Adicionar;
using aula2.DTO.Heroi.Atualizar;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Teste.UseCase.Builder
{
    class AtualizarHeroiRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarHeroiRequest _AtualizarHeroi;
        public AtualizarHeroiRequestBuilder()
        {
            _AtualizarHeroi = new AtualizarHeroiRequest();
            _AtualizarHeroi.nome = _faker.Random.String(15);
            _AtualizarHeroi.poderid = _faker.Random.Int(0);
            _AtualizarHeroi.fraquesaid = _faker.Random.Int(0);
            _AtualizarHeroi.fantasiaid = _faker.Random.Int(0);

        }

        public AtualizarHeroiRequest Build()
        {
            return _AtualizarHeroi;
        }
    }
}
