using aula2.context;
using aula2.DTO.Heroi.AdicionarHeroi;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Repositorio
{
    public class RepositorioHeroi : IRepositorioHeroi
    {
        private readonly LocalDBContext _local;

        public RepositorioHeroi(LocalDBContext local)
        {
            _local = local;
        }

        public void Add(Heroi request)
        {
            _local.heroi.Add(request);
            _local.SaveChanges();
        }
    }
}
