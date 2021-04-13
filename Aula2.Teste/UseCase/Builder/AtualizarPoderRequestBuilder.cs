using aula2.DTO.Heroi.Adicionar;
using aula2.DTO.Poder.Atulizar;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Teste.UseCase.Builder
{
    class AtualizarPoderRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarPoderRequest _AtualizarPoder;
        public AtualizarPoderRequestBuilder()
        {
            _AtualizarPoder = new AtualizarPoderRequest();
            _AtualizarPoder.nome = _faker.Random.String(15);

        }

        public AtualizarPoderRequest Build()
        {
            return _AtualizarPoder;
        }
    }
}
