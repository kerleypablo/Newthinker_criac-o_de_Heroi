using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface IPoderService
    {

        bool AdicionarPoder(Poderes poderes);
        List<Poderes> RetornarListadePoderes();
        Poderes RetornarPoderporId(int id);
        bool AtualizarPoder(Poderes poderes);
        bool DeletarPoder(int id);



    }
}
