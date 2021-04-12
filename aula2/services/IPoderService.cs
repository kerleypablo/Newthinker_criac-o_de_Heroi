using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface IPoderService
    {

        bool AdicionarPoder(Poder poderes);
        List<Poder> RetornarListadePoderes();
        Poder RetornarPoderporId(int id);
        bool AtualizarPoder(Poder poderes);
        bool DeletarPoder(int id);



    }
}
