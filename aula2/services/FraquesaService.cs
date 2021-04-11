using aula2.context;
using aula2.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.services
{
    public class FraquesaService : IFraquesaService
    {
        private readonly LocalDBContext _local;

        public FraquesaService(LocalDBContext local)
        {
            _local = local;
        }

        bool IFraquesaService.AdicionarFraquesa(Fraquesa fraquesa)
        {
            _local.fraquesa.Add(fraquesa);
            _local.SaveChanges();
            return true;
        }



        bool IFraquesaService.AtualizarFraquesa(Fraquesa fraquesa)
        {
            _local.fraquesa.Attach(fraquesa);
            _local.Entry(fraquesa).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        bool IFraquesaService.DeletarFraquesa(int id)
        {
            var objetoApagar = _local.produto.Where(d => d.id == id).FirstOrDefault();
            _local.produto.Remove(objetoApagar);
            _local.SaveChanges();
            return true;
        }

        List<Fraquesa> IFraquesaService.RetornarListadeFraquesa()
        {
            return _local.fraquesa.ToList();
        }

        Poderes IFraquesaService.RetornarFraquesaporId(int id)
        {
            return _local.poder.Where(d => d.id == id).FirstOrDefault();
        }
    }
}
