using aula2.Bordas.Repositorio;
using aula2.context;
using aula2.entities;
using System.Collections.Generic;
using System.Linq;

namespace aula2.Repositorio
{
    public class RepositorioFraqueza : IRepositorioFraqueza
    {
        private readonly LocalDBContext _local;
        public RepositorioFraqueza(LocalDBContext local)
        {
            _local = local;
        }
        public int Add(Fraqueza fraqueza)
        {
            _local.fraqueza.Add(fraqueza);
            _local.SaveChanges();
            return fraqueza.id;
        }

        public void Atualizar(Fraqueza fraqueza)
        {
            _local.fraqueza.Attach(fraqueza);
            _local.SaveChanges();
        }

        public IEnumerable<Fraqueza> Listar()
        {
            return _local.fraqueza.ToList();
        }

        public Fraqueza Obter(int id)
        {
            var obj = _local.fraqueza.FirstOrDefault(d => d.id == id);
            return obj;
        }

        public void Remover(int id)
        {
            var obj = _local.fraqueza.FirstOrDefault(d => d.id == id);
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.fraqueza.Remove(obj);
            _local.SaveChanges();
        }
    }
}
