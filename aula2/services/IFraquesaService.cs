using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface IFraquesaService
    {

        bool AdicionarFraquesa(Fraquesa fraquesa);
        List<Fraquesa> RetornarListadeFraquesa();
        Poderes RetornarFraquesaporId(int id);
        bool AtualizarFraquesa(Fraquesa fraquesa);
        bool DeletarFraquesa(int id);



    }
}
