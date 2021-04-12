using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class HeroiService : IHeroiService
    {
        private readonly LocalDBContext _local;

        public HeroiService(LocalDBContext local)
        {
            _local = local;
        }

        bool IHeroiService.AdicionarHeroi(Heroi heroi)
        {
            _local.heroi.Add(heroi);
            _local.SaveChanges();
            return true;
        }

        bool IHeroiService.AtualizarHeroi(Heroi novoHeroi)
        {
            _local.heroi.Attach(novoHeroi);
            _local.Entry(novoHeroi).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool IHeroiService.DeletarHeroi(int id)
        {
            var objetoApagar = _local.heroi.Where(d => d.id == id).FirstOrDefault();
            _local.heroi.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Heroi> IHeroiService.RetornarListadeHeroi()
        {
            return _local.heroi.ToList();
        }

        Heroi IHeroiService.RetornarHeroiporId(int id)
        {
            return _local.heroi.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
