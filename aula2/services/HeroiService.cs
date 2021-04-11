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

      Poderes IHeroiService.AdicionarPoderporId(Poderes id)
        {
            _local.poder.Add(id);
            _local.SaveChanges();
            return id;

           
        }


        Fraquesa IHeroiService.AdicionarFraquesaporId(Fraquesa id)
        {
            _local.fraquesa.Add(id);
            _local.SaveChanges();
            return id;


        }

        Fantasia IHeroiService.Adicionarfantasiaporid(Fantasia id)
        {
            _local.fantasia.Add(id);
            _local.SaveChanges();
            return id;


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
            var objetoApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objetoApagar);
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
