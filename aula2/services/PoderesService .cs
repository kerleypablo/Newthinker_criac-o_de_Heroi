using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class PoderesService : IPoderService
    {
        private readonly LocalDBContext _local;

        public PoderesService(LocalDBContext local)
        {
            _local = local;
        }

        bool IPoderService.AdicionarPoder(Poderes poderes)
        {
            _local.poder.Add(poderes);
            _local.SaveChanges();
            return true;
        }



        bool IPoderService.AtualizarPoder(Poderes novoPoder)
        {
            _local.poder.Attach(novoPoder);
            _local.Entry(novoPoder).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool IPoderService.DeletarPoder(int id)
        {
            var objetoApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Poderes> IPoderService.RetornarListadePoderes()
        {
            return _local.poder.ToList();
        }

        Poderes IPoderService.RetornarPoderporId(int id)
        {
            return _local.poder.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
