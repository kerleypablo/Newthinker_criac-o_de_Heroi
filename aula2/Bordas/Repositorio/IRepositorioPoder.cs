using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.Repositorio
{
    public interface IRepositorioPoder
    {
        int Add(Poder poder);

        void Atualizar(Poder poder);

        void Remover(int id);

        Poder Obter(int id);

        IEnumerable<Poder> Listar();
    }
}
