using aula2.entities;
using System.Collections.Generic;


namespace aula2.Bordas.Repositorio
{
    public interface IRepositorioFraqueza
    {
        int Add(Fraqueza fraqueza);

        void Atualizar(Fraqueza fraquesza);

        void Remover(int id);

        Fraqueza Obter(int id);

        IEnumerable<Fraqueza> Listar();
    }
}
