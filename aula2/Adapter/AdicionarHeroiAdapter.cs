using aula2.Bordas.Adapter;
using aula2.DTO.Heroi.AdicionarHeroi;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Adapter
{
    public class AdicionarHeroiAdapter : IAdicionarHeroi
    {
        public Heroi ConvertRequestParaProduto(AdicionarHeroiRequest request)
        {
            var novoHeroi = new Heroi();
            novoHeroi.nome = request.nome;
            novoHeroi.poder = request.poder;
            novoHeroi.fraquesa = request.fraquesa;
            return novoHeroi;
            throw new NotImplementedException();
        }
    }
}
