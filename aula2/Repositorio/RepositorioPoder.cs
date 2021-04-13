using aula2.Bordas.Repositorio;
using aula2.context;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Repositorio
{
    public class RepositorioPoder : IRepositorioPoder
    {
        private readonly LocalDBContext _local;
        public RepositorioPoder(LocalDBContext local)
        {
            _local = local;
        }


        public int Add(Poder poder)
        {
            _local.poder.Add(poder);
            _local.SaveChanges();
            return poder.id;
        }

        public void Atualizar(Poder poder)
        {
            _local.poder.Attach(poder);
            _local.SaveChanges();
        }

        public IEnumerable<Poder> Listar()
        {
            return _local.poder.ToList();
        }

        public Poder Obter(int id)
        {
            var obj = _local.poder.FirstOrDefault(d => d.id == id);
            return obj;
        }

        public void Remover(int id)
        {
            var obj = _local.poder.FirstOrDefault(d => d.id == id);
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.poder.Remove(obj);
            _local.SaveChanges();
        }
    }
}
