using aula2.entities;
using System.Collections.Generic;

namespace aula2.Repositorio
{
    public interface IRepositorioHeroi
    {
        int Add(Heroi heroi);

        void Atualizar(Heroi heroi);

        void Remover(int id);

        Heroi Obter(int id);

        IEnumerable<Heroi> Listar();
    }
}
