using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class FantasiaService : IFantasiaService
    {
        private readonly LocalDBContext _local;

        public FantasiaService(LocalDBContext local)
        {
            _local = local;
        }

        bool IFantasiaService.AdicionarFantasia(Fantasia fantasia)
        {
            _local.fantasia.Add(fantasia);
            _local.SaveChanges();
            return true;
        }

      Poderes IFantasiaService.AdicionarPoderporId(Poderes id)
        {
            _local.poder.Add(id);
            _local.SaveChanges();
            return id;

           
        }


        Fraquesa IFantasiaService.AdicionarFraquesaporId(Fraquesa id)
        {
            _local.fraquesa.Add(id);
            _local.SaveChanges();
            return id;


        }



        bool IFantasiaService.AtualizarFantasia(Fantasia fantasia)
        {
            _local.fantasia.Attach(fantasia);
            _local.Entry(fantasia).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool IFantasiaService.DeletarFantasia(int id)
        {
            var objetoApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Fantasia> IFantasiaService.RetornarListadeFantasia()
        {
            return _local.fantasia.ToList();
        }

        Heroi IFantasiaService.RetornarfantasiaporId(int id)
        {
            return _local.heroi.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
