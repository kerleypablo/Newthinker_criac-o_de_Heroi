using aula2.context;
using aula2.entities;
using System.Collections.Generic;
using System.Linq;

namespace aula2.Repositorio
{
    public class RepositorioHeroi : IRepositorioHeroi
    {
        private readonly LocalDBContext _local;

        public RepositorioHeroi(LocalDBContext local)
        {
            _local = local;
        }

        public int Add(Heroi heroi)
        {
            _local.heroi.Add(heroi);
            _local.SaveChanges();
            return heroi.id;
        }

        public void Atualizar(Heroi heroi)
        {
            _local.heroi.Attach(heroi);
            _local.SaveChanges();
        }

        public IEnumerable<Heroi> Listar()
        {
            return _local.heroi.ToList();
        }

        public Heroi Obter(int id)
        {
            var obj = _local.heroi.FirstOrDefault(d => d.id == id);
            return obj;
        }

        public void Remover(int id)
        {
            var obj = _local.heroi.FirstOrDefault(d => d.id == id);
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.heroi.Remove(obj);
            _local.SaveChanges();
        }
    }
}
